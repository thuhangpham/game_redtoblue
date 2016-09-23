using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueToRed
{
    public partial class Form1 : Form
    {
        int cellSize = 100;
        int countCell = 5, countMoved = 0;
        int padingPanel = 12;
        Panel panel1;
        Label[] cellColor;

        public Form1()
        {
            InitializeComponent();
            InitializeCell();
        }
        void InitializeCell()
        {

            if (countCell > 5)
                cellSize = 70;
            if (countCell > 8)
                cellSize = 50;
            cellColor = new Label[countCell * countCell];
            panel1 = new Panel();
            panel1.BackColor = Color.Lavender;
            panel1.Location = new Point(padingPanel, padingPanel);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.BackColor = Color.Peru;
            panel1.Size = new Size(cellSize * countCell + countCell-1, cellSize * countCell + countCell-1);
            int pos = 0;
            for (int i = 0; i < countCell; i++)
                for (int j = 0; j < countCell; j++)
                {
                    cellColor[pos] = new Label();
                    cellColor[pos].Width = cellSize;
                    cellColor[pos].Height = cellSize;
                    cellColor[pos].BackColor = Color.Blue;
                    cellColor[pos].Location = new Point(j * (cellSize + 1), i * (cellSize + 1));
                    panel1.Controls.Add(cellColor[pos]);
                    pos++;
                }
            this.Controls.Add(panel1);
            btnPlay.Location = new Point(padingPanel, panel1.Height + 20);
            btnOneMove.Location = new Point(btnPlay.Location.X + 90, panel1.Height + 20);
            this.Size = new Size(padingPanel * 2 + panel1.Width + 10+20, panel1.Height + padingPanel + 50 + 30 + 20);
            btnPlay.Enabled = true;
            lblMoved.Location = new Point(countCell * cellSize / 2, btnPlay.Location.Y);
            lblCounted.Location = new Point((countCell - 1) * cellSize, btnPlay.Location.Y);
            if (int.Parse(lblMoved.Text) != 1 && int.Parse(lblCounted.Text) > int.Parse(lblMoved.Text) || lblCounted.Text == "0")
                lblCounted.Text = lblMoved.Text;
            btnOneMove.Enabled = false;
        }
        private void picColorClick(object sender, EventArgs e)
        {
            int sumCell = countCell * cellSize + countCell;
            Label picColor = (Label)sender;
            int k = (picColor.Location.Y % cellSize) * countCell +
                 (picColor.Location.X % cellSize);
            ChangeColor(picColor);
            if ((k % countCell) != 0)
                ChangeColor(cellColor[k - 1]);
            if (k < cellColor.Length - 1 && ((k + 1) % countCell) != 0)
                ChangeColor(cellColor[k + 1]);
            if (k < cellColor.Length - countCell)
                ChangeColor(cellColor[k + countCell]);
            if (k >= countCell)
                ChangeColor(cellColor[k - countCell]);
            lblMoved.Text = (++countMoved).ToString();
            Check();
        }
        void ChangeColor(Label a)
        {
            if (a.BackColor == Color.Red)
                a.BackColor = Color.Blue;
            else
                a.BackColor = Color.Red;
        }

        private void btnOneMove_Click(object sender, EventArgs e)
        {
            int max = cellColor.Length;
            for (int i = 0; i < max; i++)
                cellColor[i].BackColor = Color.Blue;
            Random rnd = new Random();
            int k = rnd.Next(max - 1);
            cellColor[k].BackColor = Color.Red;
            if ((k % countCell) != 0)
                cellColor[k - 1].BackColor = Color.Red;
            // o cuoi cung va o bien phai
            // random chay tu 0 -> n-1
            // k+1 -> so o dc chia het.
            if (k < cellColor.Length - 1 && ((k + 1) % countCell) != 0)
                cellColor[k + 1].BackColor = Color.Red;
            // o phia duoi
            if (k < cellColor.Length - countCell)
                cellColor[k + countCell].BackColor = Color.Red;
            // o phia tren
            if (k >= countCell)
                cellColor[k - countCell].BackColor = Color.Red;
        }
        void Check()
        {
            int d = 0;
            for (int i = 0; i < cellColor.Length; i++)
                if (cellColor[i].BackColor == Color.Blue)
                    d++;
            if (d == cellColor.Length)
            {
                btnPlay.Enabled = true;
                btnOneMove.Enabled = false;
                MessageBox.Show("Chúc mừng bạn đã chiền thắng.\n Click Play để chơi nữa nhé!^_^ ", "Cung sỉ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Controls.Remove(panel1);
                countMoved = 0;
                InitializeCell();
            }
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            lblMoved.Enabled = true;
            btnPlay.Enabled = false;
            lblMoved.Text = "0";
            int t = cellColor.Length - 1;
            while (t >= 0)
            {
                Application.DoEvents();
                cellColor[t].BackColor = Color.Red;
                t--;
                Thread.Sleep(5);
            }
            btnOneMove.Enabled = true;
            for (int i = 0; i < countCell * countCell; i++)
            {
                cellColor[i].Click += picColorClick;
            }
        }
      
    }
}
