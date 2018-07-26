using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

using iTextSharp.text;
using iTextSharp.text.pdf;

namespace 流量计检定上位机
{
    public class ExportReporter
    {
        const string HalfOfA4Str = "                                                                           ";
        const string ConfigPath = "C:\\ProgramData\\FlowMeterConfig";
        const string PdfSaveFilter = "生成pdf（*.pdf）|*.pdf";

        DemarcateMotion[] demaMotionArray;
        List<DemarcateMotionSave> demaMotionList;

        public ExportReporter(DemarcateMotion[] demaMotion)
        {
            demaMotionArray = demaMotion;
        }

        public ExportReporter(List<DemarcateMotionSave> demaMotion)
        {
            demaMotionList = demaMotion;

        }

        public void Export(SaveFileDialog saveFileDialog)
        {
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.Filter = PdfSaveFilter;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var savePath = saveFileDialog.FileName;

                BaseFont bfSun = BaseFont.createFont(@"c:\windows\Fonts\simsun.ttc,0", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                Font font = new Font(bfSun, 12);
                Font fontSmall = new Font(bfSun, 9);
                Font fontTable = new Font(bfSun, 11);
                Paragraph paragraph;

                Document document = new Document(PageSize.A4);
                try
                {
                    PdfWriter.getInstance(document, new FileStream(savePath, FileMode.Create));
                    #region 打开PDF
                    document.addTitle("ReportForm");
                    document.addSubject("About DemarcateResults");
                    document.addKeywords("Demarcate");
                    document.addCreator("DuGu");
                    document.addAuthor("DuGu");
                    document.addHeader("Expires", "0");
                    document.Open();
                    #endregion
                    #region 生成的内容
                    //1
                    paragraph = new Paragraph("标定结果\r\n", new Font(bfSun, 14f));
                    paragraph.Alignment = Element.ALIGN_CENTER;
                    document.Add(paragraph); document.Add(new Phrase("\r\n"));
                    //2
                    document.Add(new Phrase("工作表", font));
                    document.Add(new Phrase("                                                                     "));
                    document.Add(new Phrase("序列号\r\n", font));
                    //3
                    document.Add(new Phrase("ＣＭＦ３００Ｍ３５５ＮＱＰＭＥＺＺＺ", font));
                    document.Add(new Phrase("              "));
                    document.Add(new Phrase("１４２５００００\r\n", font));
                    //4
                    document.Add(new Phrase("１７００Ｒ１１ＡＢＰＭＺＺＺ        ", font));
                    document.Add(new Phrase("              "));
                    document.Add(new Phrase("１４２３００００\r\n", font));
                    //5
                    document.Add(new Phrase("\r\n"));
                    //6
                    //7
                    document.Add(new Phrase("标定介质:        水                         ", font));
                    document.Add(new Phrase("介质温度:        ℃  \r\n", font));
                    //8
                    document.Add(new Phrase("介质压力：	      ０.４ＭＰａ \r\n", font));
                    //9
                    //10
                    document.Add(new Phrase("标定数据：\r\n", font));
                    //11

                    Table aTable = new Table(8, 13);
                    aTable.Cellpadding = 2;
                    ExportOptions exportOptions = new ExportOptions();
                    foreach (string str in exportOptions.TableString)
                    {
                        aTable.addCell(new Phrase(str, fontTable));

                    }
                    if(demaMotionArray != null)
                    {
                        for (int i = 1; i <= 12; ++i)
                        {
                            aTable.addCell(" " + i.ToString());
                            for (int j = 0; j < 7; ++j)
                            {
                                aTable.addCell(Math.Round(demaMotionArray[i - 1].Para[j], 3).ToString());
                            }

                        }
                    }
                    if(demaMotionList != null)
                    {
                        for (int i = 1; i <= 12; ++i)
                        {
                            aTable.addCell(" " + i.ToString());
                            for (int j = 0; j < 7; ++j)
                            {
                                aTable.addCell(Math.Round(demaMotionList[i - 1].Para[j], 3).ToString());
                            }

                        }
                    }

                    document.Add(aTable);
                    //12
                    document.Add(new Phrase("\r\n"));
                    //13
                    document.Add(new Phrase("基本误差：　　　％\r\n", font));
                    //14
                    document.Add(new Phrase("重复性：　　　　％\r\n", font));
                    //15
                    document.Add(new Phrase("仪表系数：\r\n", font));
                    //16
                    document.Add(new Phrase("\r\n"));
                    //18
                    document.Add(new Phrase("环境条件：温度：　　　°Ｃ；　气压：　　　　ＭＰａ。\r\n", font));
                    //19
                    document.Add(new Phrase("标定用标准设备：     \r\n", font));
                    //20
                    document.Add(new Phrase("\r\n"));
                    //21
                    document.Add(new Phrase("标准表", font));
                    document.Add(new Phrase("                                                                  "));
                    document.Add(new Phrase("序列号 ", font));
                    document.Add(new Phrase("                           "));
                    document.Add(new Phrase("标准不确定度 \r\n", font));
                    //22
                    document.Add(new Phrase("ＣＭＦ３００Ｍ４２５Ｎ０ＡＭＥＺＺＺ", font));
                    document.Add(new Phrase("           "));
                    document.Add(new Phrase("１４０９２６５０", font));
                    document.Add(new Phrase("           "));
                    document.Add(new Phrase("０．０５％ \r\n", font));
                    //23
                    document.Add(new Phrase("２４００ＳＩＡ１１ＭＥＺＺＺ        ", font));
                    document.Add(new Phrase("           "));
                    document.Add(new Phrase("１００３６２０３", font));
                    document.Add(new Phrase("           "));
                    document.Add(new Phrase("   \r\n", font));
                    //EndWithTime
                    paragraph = new Paragraph("生成报表时间:" + DateTime.Now, font);
                    paragraph.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragraph);


                    #endregion
                }
                catch (DocumentException de)
                {
                    throw (de);
                }
                catch (IOException ioe)
                {
                    throw (ioe);
                }
                document.Close();
                MessageBox.Show("生成PDF报表成功！");
            }
        }

    }
}
