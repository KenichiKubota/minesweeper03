using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper03
{
    public partial class MyCell : CheckBox
    {

        // 通し番号
        private int SeqNum;

        // 爆弾かどうかを判定するフラグ（爆弾ならtrue）
        private Boolean BombFlag;

        // このセルの周囲のセルを格納するリスト
        private List<MyCell> aroundCells = new List<MyCell>();

        //------------------------------------------
        // 周囲のセルを一気にセットする
        //------------------------------------------
        public void AddAroundCells(params MyCell[] aroundCells)
        {
            foreach(MyCell arroundCell in aroundCells)
            {
                this.aroundCells.Add(arroundCell);
            }
        }

        public MyCell(int SeqNum, int locationX,int locationY,Boolean BombFlag) :base()
        {
            //InitializeComponent();
            //base.Appearance = Appearance.Button;
            //base.Margin = new System.Windows.Forms.Padding(0);
            //this.AutoSize = true;
            //this.Location = new System.Drawing.Point(locationX, locationY);
            //this.Size = new System.Drawing.Size(30, 30);
            //base.TabIndex = 1;
            //this.UseVisualStyleBackColor = true;
            base.Appearance = Appearance.Button;
            base.Margin = new System.Windows.Forms.Padding(0);
            base.Size = new System.Drawing.Size(30, 30);
            base.TabIndex = 1;
            base.UseVisualStyleBackColor = true;
            base.Location = new System.Drawing.Point(locationX, locationY);
            this.BombFlag = BombFlag;
            this.SeqNum = SeqNum;
        }

        public MyCell(IContainer container)
        {
            InitializeComponent();
        }

        //------------------------------------------
        // クリックされたときに起こるイベント
        //------------------------------------------
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            switch (mevent.Button)
            {
                // 左クリックしたとき
                case MouseButtons.Left:
                    this.OnLeftClick();
                    break;
                // 右クリックしたとき
                case MouseButtons.Right:
                    this.OnRightClick();
                    break;

            }
        }

        //------------------------------------------
        // 左クリックしたときの処理
        //------------------------------------------
        private void OnLeftClick()
        {
            // チェック済みのときは即終了
            if (base.Checked)
            {
                return;
            }

            // チェックする
            base.Checked = true;

            // 爆弾なら「B」を表示
            if (BombFlag == true)
            {
                base.Text = "B";
            }
            else
            {

                // 周囲の爆弾の数をカウントする
                int ArroundBombCount = 0;

                foreach (MyCell aroundCell in aroundCells)
                {
                    if(aroundCell.BombFlag)
                    {
                        ArroundBombCount++;
                    }
                }

                
                if (ArroundBombCount == 0)
                {
                    // 周囲の爆弾の数が0なら、周囲のセルを左クリックする
                    foreach (MyCell aroundCell in aroundCells)
                    {
                        aroundCell.OnLeftClick();
                    }
                }
                else
                {
                    // 周囲の爆弾の数が0でなければ、その数を表示
                    base.Text = ArroundBombCount.ToString();
                }
                
            }
        }

        //------------------------------------------
        // 右クリックしたときの処理
        //------------------------------------------
        private void OnRightClick()
        {

        }
    }
}
