using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using ZedGraph;

namespace 流量计检定上位机.CDM
{
    class ZedGraghUtils
    {
        int tickStart;
        ZedGraphControl zedgraphControl;

        public ZedGraghUtils(ZedGraphControl control)
        {
            zedgraphControl = control;
        }

        public void Init(ChartParameters paras)
        {
            GraphPane myPane = zedgraphControl.GraphPane;
            myPane.XAxis.Title.Text = paras.XTitle;
            myPane.YAxis.Title.Text = paras.YTitle;
            RollingPointPairList list = new RollingPointPairList(200000);
            LineItem curve = myPane.AddCurve(paras.CurveName, list, Color.Red, SymbolType.None);

            myPane.AddCurve("正弦", new RollingPointPairList(20000), Color.Blue, SymbolType.Star);

            myPane.YAxis.Scale.Max = paras.YMax;
            myPane.YAxis.Scale.Min = paras.YMin;
            myPane.XAxis.Scale.MinorStep = 1;
            myPane.XAxis.Scale.MajorStep = 1;
            zedgraphControl.AxisChange();
            tickStart = Environment.TickCount;
        }

        public void Start()
        {
            //tickStart = Environment.TickCount;
        }

        public void Clear()
        {
            if (zedgraphControl.GraphPane.CurveList.Count <= 0)
                return;
            LineItem curve = zedgraphControl.GraphPane.CurveList[0] as LineItem;
            if (curve == null)
                return;
            IPointListEdit list = curve.Points as IPointListEdit;
            if (list == null)
                return;
            list.Clear();

        }

        public void RenewYScale(ChartParameters paras)
        {
            GraphPane myPane = zedgraphControl.GraphPane;
            myPane.YAxis.Scale.Max = paras.YMax;
            myPane.YAxis.Scale.Min = paras.YMin;
        }

        public void TimeDraw(double addData)
        {
            if (zedgraphControl.GraphPane.CurveList.Count <= 0)
                return;
            LineItem curve = zedgraphControl.GraphPane.CurveList[0] as LineItem;
            if (curve == null)
                return;
            IPointListEdit list = curve.Points as IPointListEdit;
            if (list == null)
                return;
            double time = (Environment.TickCount - tickStart) / 1000.0;
            list.Add(time,new Random().Next(7));
            //list.Add(time, addData);

            LineItem curve2 = zedgraphControl.GraphPane.CurveList[1] as LineItem;
            IPointListEdit list2 = curve2.Points as IPointListEdit;
            list2.Add(time, 6 + Math.Sin(time));

            Scale xScale = zedgraphControl.GraphPane.XAxis.Scale;
            if(time > xScale.Max - xScale.MajorStep)
            {
                xScale.Min = time + xScale.MajorStep;
                xScale.Max = xScale.Min + 300;
            }
            zedgraphControl.AxisChange();
            zedgraphControl.Invalidate();
        }


    }
}
