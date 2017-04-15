using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using NPOI.HPSF;
using NPOI.HSSF.UserModel;

namespace 流量计检定上位机
{
    class ExportExcel
    {
        const string strHeaderText = "标定数据";
        int ColumnCount = 8;
        const string ExcelSaveFilter = "生成excel（*.xls）|*.xls";
        DemarcateMotion[] demaMotionArray;
        List<DemarcateMotionSave> demaMotionList;

        ExportExcel() { }

        public ExportExcel(DemarcateMotion[] demaMotion)
        {
            demaMotionArray = demaMotion;
        }
        public ExportExcel(List<DemarcateMotionSave> demaMotion)
        {
            demaMotionList = demaMotion;
        }
       
        public void Export(SaveFileDialog saveFileDialog)
        {
            try
            {
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.Filter = ExcelSaveFilter;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var savePath = saveFileDialog.FileName;
                    using (MemoryStream ms = Export(true))
                    {
                        using (FileStream fs = new FileStream(savePath, FileMode.Create, FileAccess.Write))
                        {
                            byte[] data = ms.ToArray();
                            fs.Write(data, 0, data.Length);
                            fs.Flush();
                        }
                    }
                    MessageBox.Show("生成Excel成功！");
                }

            }
            catch(Exception ex)
            {
                throw (ex);
            }
        }

        MemoryStream Export(bool isPrivate)
        {
            HSSFWorkbook workBook = new HSSFWorkbook();
            HSSFSheet sheet = (HSSFSheet)workBook.CreateSheet();

            #region 右击文件属性信息
            {
                DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();

                dsi.Company = "DuGu";
                workBook.DocumentSummaryInformation = dsi;

                SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
                si.Author = "DuGu";
                si.ApplicationName = "DuGu_NPOI_" + AppInfo.GetName();
                si.LastAuthor = "DuGu";
                si.Comments = "DuGu";
                si.Title = "DuGu";
                si.Subject = "DemarcateResults";
                si.CreateDateTime = DateTime.Now;
                workBook.SummaryInformation = si;

            }
            #endregion

            HSSFCellStyle dateStyle = (HSSFCellStyle)workBook.CreateCellStyle();
            HSSFDataFormat format = (HSSFDataFormat)workBook.CreateDataFormat();
            dateStyle.DataFormat = format.GetFormat("yyyy-mm-dd");

            int[] arrColWidth  = {20,20,20,20,20,20,20,20 };
            #region 表头样式
            HSSFRow headerRow = (HSSFRow)sheet.CreateRow(0);
            headerRow.HeightInPoints = 25;
            headerRow.CreateCell(0).SetCellValue(strHeaderText);

            HSSFCellStyle headStyle = (HSSFCellStyle)workBook.CreateCellStyle();
            headStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            HSSFFont font = (HSSFFont)workBook.CreateFont();
            font.FontHeightInPoints = 25;
            font.Boldweight = 400;
            headStyle.SetFont(font);
            headerRow.GetCell(0).CellStyle = headStyle;
            sheet.AddMergedRegion(new NPOI.SS.Util.Region(0, 0, 0, ColumnCount - 1));
            #endregion

            headerRow = (HSSFRow)sheet.CreateRow(1);
            headStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
            font.FontHeightInPoints = 25;
            font.Boldweight = 400;
            headStyle.SetFont(font);
            ExportOptions exportOptions = new ExportOptions();
            for(int i = 0;i< ColumnCount; ++i)
            {
                headerRow.CreateCell(i).SetCellValue(exportOptions.TableString[i]);
                headerRow.GetCell(i).CellStyle = headStyle;
                sheet.SetColumnWidth(i, (arrColWidth[i] + 1) * 256);
            }
            for(int i=0;i<12 ;++i)
            {
                headerRow = (HSSFRow)sheet.CreateRow(i + 2);
                headStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                font.FontHeightInPoints = 15;
                font.Boldweight = 400;
                headStyle.SetFont(font);

                headerRow.CreateCell(0).SetCellValue(i + 1);
                headerRow.GetCell(0).CellStyle = headStyle;
                if(demaMotionArray != null)
                {
                    for (int j = 1; j < ColumnCount; ++j)
                    {
                        headerRow.CreateCell(j).SetCellValue(demaMotionArray[i].Para[j - 1].ToString());
                        headerRow.GetCell(j).CellStyle = headStyle;
                        sheet.SetColumnWidth(j, (arrColWidth[j] + 1) * 256);
                    }
                }
                if(demaMotionList != null)
                {
                    for (int j = 1; j < ColumnCount; ++j)
                    {
                        headerRow.CreateCell(j).SetCellValue(demaMotionList[i].Para[j - 1].ToString());
                        headerRow.GetCell(j).CellStyle = headStyle;
                        sheet.SetColumnWidth(j, (arrColWidth[j] + 1) * 256);
                    }
                }

            }
            using (MemoryStream ms = new MemoryStream())
            {
                workBook.Write(ms);
                ms.Flush();
                ms.Position = 0;
                return ms;
            }
        }

    }
}
