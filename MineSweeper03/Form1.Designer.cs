namespace MineSweeper03
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // checkBox1
            // 

            // セルのインスタンスを一つずつ作る
            myCell1 = new MyCell(1, 0, 0, true);
            myCell2 = new MyCell(2, 30, 0, false);
            myCell3 = new MyCell(3, 60, 0, false);
            myCell4 = new MyCell(4, 0, 30, false);
            myCell5 = new MyCell(5, 30, 30, false);
            myCell6 = new MyCell(6, 60, 30, false);
            myCell7 = new MyCell(7, 0, 60, false);
            myCell8 = new MyCell(8, 30, 60, false);
            myCell9 = new MyCell(9, 60, 60, false);

            // セルにその周囲のセルをセットする
            myCell1.AddAroundCells(myCell2, myCell4, myCell5);
            myCell2.AddAroundCells(myCell1, myCell3, myCell4, myCell5, myCell6);
            myCell3.AddAroundCells(myCell2, myCell5, myCell6);
            myCell4.AddAroundCells(myCell1, myCell2, myCell5, myCell7, myCell8);
            myCell5.AddAroundCells(myCell1, myCell2, myCell3, myCell4, myCell6, myCell7, myCell8, myCell9);
            myCell6.AddAroundCells(myCell2, myCell3, myCell5, myCell8, myCell9);
            myCell7.AddAroundCells(myCell4, myCell5, myCell8);
            myCell8.AddAroundCells(myCell4, myCell5, myCell6, myCell7, myCell9);
            myCell9.AddAroundCells(myCell5, myCell6, myCell8);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);

            // セルを画面に表示する
            this.Controls.Add(this.myCell1);
            this.Controls.Add(this.myCell2);
            this.Controls.Add(this.myCell3);
            this.Controls.Add(this.myCell4);
            this.Controls.Add(this.myCell5);
            this.Controls.Add(this.myCell6);
            this.Controls.Add(this.myCell7);
            this.Controls.Add(this.myCell8);
            this.Controls.Add(this.myCell9);

            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCell myCell1;
        private MyCell myCell2;
        private MyCell myCell3;
        private MyCell myCell4;
        private MyCell myCell5;
        private MyCell myCell6;
        private MyCell myCell7;
        private MyCell myCell8;
        private MyCell myCell9;

    }
}

