using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_StructAndClass
{
    public partial class Form1 : Form
    {
        //class structPlayerClass
        //{
        //    public int iCount =0; // 플레이가 몇회 진행 중인지.

        //    public int iSun =2; // 해에 대한 값
        //    public int iMoon =3; // 달에 대한 값
        //    public int iStar=3; // 별에 대한 값

        //    public int iCardSum; // 해, 달, 별을 더한 값

        //    //값들을 더해서 반환
        //    public int CardSum(int iSum, int iMoon, int iSar)
        //    {
        //        return iSun + iMoon + iSar;
        //    }
        //    //결과를 string 형태로 반환 (화면에 결과를 보여주기 위해 사용)
        //    public string ResultText()
        //    {
        //        return string.Format("{0}회) 해:{1}, 달:{2}, 별:{3} => 합계는 {4} 입니다.", iCount, iSun, iMoon, iStar, iCardSum);
        //    }
        //}
        struct structPlayer
        {
            public int iCount; // 플레이가 몇회 진행 중인지.

            public int iSun; // 해에 대한 값
            public int iMoon; // 달에 대한 값
            public int iStar; // 별에 대한 값

            public int iCardSum; // 해, 달, 별을 더한 값

            //값들을 더해서 반환
            public int CardSum(int iSum, int iMoon, int iSar)
            {
                return iSun + iMoon + iSar;
            }
            //결과를 string 형태로 반환 (화면에 결과를 보여주기 위해 사용)
            public string ResultText()
            {
                return string.Format("{0}회) 해:{1}, 달:{2}, 별:{3} => 합계는 {4} 입니다.", iCount, iSun, iMoon, iStar, iCardSum);
            }
        }
        structPlayer _stPlayer1; //1번플레이어
        structPlayer _stPlayer2; //2번플레이어
        Random _rd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void pboxSun_Click(object sender, EventArgs e)
        {

            int iNumber = _rd.Next(1, 21);

            if (radioPlayer1.Checked)
            {
                _stPlayer1.iSun = iNumber;
            }
            else
            {
                _stPlayer2.iSun = iNumber;
            }
            Result();
        }

        private void pboxMoon_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (radioPlayer1.Checked)
            {
                _stPlayer1.iMoon = iNumber;
            }
            else
            {
                _stPlayer2.iMoon = iNumber;
            }
            Result();
        }

        private void pboxStar_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (radioPlayer1.Checked)
            {
                _stPlayer1.iStar = iNumber;
            }
            else
            {
                _stPlayer2.iStar = iNumber;
            }
            Result();

            
        }

        private void pboxNone_Click(object sender, EventArgs e)
        {
            //아무짓도 안하고 한턴을 넘긴다.
            iCheckedChange();
        }
        private void iCheckedChange()
        {
            if (radioPlayer1.Checked)
            {
                radioPlayer2.Checked = true;
            }
            else
            {
                radioPlayer1.Checked = true;
            }
        }
        private void Result()
        {
            string strResult = string.Empty;

            if (radioPlayer1.Checked)
            {
                _stPlayer1.iCount++;
                _stPlayer1.iCardSum = _stPlayer1.CardSum(_stPlayer1.iSun, _stPlayer1.iMoon, _stPlayer1.iStar);
                
                strResult = _stPlayer1.ResultText();

                lboxResult1.Items.Add(strResult);
            }
            else
            {
                _stPlayer2.iCount++;
                _stPlayer2.iCardSum = _stPlayer2.CardSum(_stPlayer2.iSun, _stPlayer2.iMoon, _stPlayer2.iStar);

                strResult = _stPlayer2.ResultText();
                lboxResult2.Items.Add(strResult);

            }

            iCheckedChange();

            if(_stPlayer1.iCount >=5 && _stPlayer2.iCount >= 5)
            {
                if(_stPlayer1.iCardSum > _stPlayer2.iCardSum)
                {
                    MessageBox.Show("Player1이 이겼습니다.");
                }
                else if(_stPlayer1.iCardSum < _stPlayer2.iCardSum)
                {
                    MessageBox.Show("Player2이 이겼습니다.");
                }
                else
                {
                    MessageBox.Show("비겼습니다.");
                }
            }
        }
    }
}
