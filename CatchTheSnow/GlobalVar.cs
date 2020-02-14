using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ClickingGames
{
    class GlobalVar
    {
        private static double _rsx, _rsy, _rsx1, _rsy1, _rsx2, _rsy2, _rsx3, _rsy3, _rsx4, _rsy4, _rsx5, _rsy5, _rsx6, _rsy6, _rsx7, _rsy7, _rsx8, _rsy8, _rsx9, _rsy9; // obstacles location points
        private static double _rsdx, _rsdy, _rsdx1, _rsdy1, _rsdx2, _rsdy2, _rsdx3, _rsdy3, _rsdx4, _rsdy4, _rsdx5, _rsdy5, _rsdx6, _rsdy6, _rsdx7, _rsdy7, _rsdx8, _rsdy8, _rsdx9, _rsdy9; // obstacles displacement 
        private static double _lsx, _lsy, _lsx1, _lsy1, _lsx2, _lsy2, _lsx3, _lsy3, _lsx4, _lsy4, _lsx5, _lsy5, _lsx6, _lsy6, _lsx7, _lsy7, _lsx8, _lsy8, _lsx9, _lsy9; // obstacles location points
        private static double _lsdx, _lsdy, _lsdx1, _lsdy1, _lsdx2, _lsdy2, _lsdx3, _lsdy3, _lsdx4, _lsdy4, _lsdx5, _lsdy5, _lsdx6, _lsdy6, _lsdx7, _lsdy7, _lsdx8, _lsdy8, _lsdx9, _lsdy9; // obstacles displacement 
        private static int _fuel = 9999999;
        private static int _ships = 5;
        private static int _score = 0;
        private static int _level = 1;
        private static bool _addOnExist = false;
        private static int _addOnItem;

        private static Rectangle _rObstacle;
        private static Rectangle _rObstacle1;
        private static Rectangle _rObstacle2;
        private static Rectangle _rObstacle3;
        private static Rectangle _rObstacle4;
        private static Rectangle _rObstacle5;
        private static Rectangle _rObstacle6;
        private static Rectangle _rObstacle7;
        private static Rectangle _rObstacle8;
        private static Rectangle _rObstacle9;

        private static PictureBox _pictureBox1 = new PictureBox();
        private static PictureBox _pictureBox2 = new PictureBox();
        private static PictureBox _pictureBox3 = new PictureBox();
        private static PictureBox _pictureBox4 = new PictureBox();
        private static PictureBox _pictureBox5 = new PictureBox();
        private static PictureBox _pictureBox6 = new PictureBox();
        private static PictureBox _pictureBox7 = new PictureBox();
        private static PictureBox _pictureBox8 = new PictureBox();
        private static PictureBox _pictureBox9 = new PictureBox();
        private static PictureBox _pictureBox10 = new PictureBox();

        private static PictureBox _pictureBox11 = new PictureBox();
        private static PictureBox _pictureBox12 = new PictureBox();
        private static PictureBox _pictureBox13 = new PictureBox();
        private static PictureBox _pictureBox14 = new PictureBox();
        private static PictureBox _pictureBox15 = new PictureBox();
        private static PictureBox _pictureBox16 = new PictureBox();
        private static PictureBox _pictureBox17 = new PictureBox();
        private static PictureBox _pictureBox18 = new PictureBox();
        private static PictureBox _pictureBox19 = new PictureBox();
        private static PictureBox _pictureBox20 = new PictureBox();

        private static SoundPlayer _player;
        
        public static double rsx
        {
            get { return _rsx; }
            set { _rsx = value; }
        }
        public static double rsy
        {
            get { return _rsy; }
            set { _rsy = value; }
        }
        public static double rsx1
        {
            get { return _rsx1; }
            set { _rsx1 = value; }
        }
        public static double rsy1
        {
            get { return _rsy1; }
            set { _rsy1 = value; }
        }
        public static double rsx2
        {
            get { return _rsx2; }
            set { _rsx2 = value; }
        }
        public static double rsy2
        {
            get { return _rsy2; }
            set { _rsy2 = value; }
        }
        public static double rsx3
        {
            get { return _rsx3; }
            set { _rsx3 = value; }
        }
        public static double rsy3
        {
            get { return _rsy3; }
            set { _rsy3 = value; }
        }
        public static double rsx4
        {
            get { return _rsx4; }
            set { _rsx4 = value; }
        }
        public static double rsy4
        {
            get { return _rsy4; }
            set { _rsy4 = value; }
        }
        public static double rsx5
        {
            get { return _rsx5; }
            set { _rsx5 = value; }
        }
        public static double rsy5
        {
            get { return _rsy5; }
            set { _rsy5 = value; }
        }
        public static double rsx6
        {
            get { return _rsx6; }
            set { _rsx6 = value; }
        }
        public static double rsy6
        {
            get { return _rsy6; }
            set { _rsy6 = value; }
        }
        public static double rsx7
        {
            get { return _rsx7; }
            set { _rsx7 = value; }
        }
        public static double rsy7
        {
            get { return _rsy7; }
            set { _rsy7 = value; }
        }
        public static double rsx8
        {
            get { return _rsx8; }
            set { _rsx8 = value; }
        }
        public static double rsy8
        {
            get { return _rsy8; }
            set { _rsy8 = value; }
        }
        public static double rsx9
        {
            get { return _rsx9; }
            set { _rsx9 = value; }
        }
        public static double rsy9
        {
            get { return _rsy9; }
            set { _rsy9 = value; }
        }

        public static double rsdx
        {
            get { return _rsdx; }
            set { _rsdx = value; }
        }
        public static double rsdy
        {
            get { return _rsdy; }
            set { _rsdy = value; }
        }
        public static double rsdx1
        {
            get { return _rsdx1; }
            set { _rsdx1 = value; }
        }
        public static double rsdy1
        {
            get { return _rsdy1; }
            set { _rsdy1 = value; }
        }
        public static double rsdx2
        {
            get { return _rsdx2; }
            set { _rsdx2 = value; }
        }
        public static double rsdy2
        {
            get { return _rsdy2; }
            set { _rsdy2 = value; }
        }
        public static double rsdx3
        {
            get { return _rsdx3; }
            set { _rsdx3 = value; }
        }
        public static double rsdy3
        {
            get { return _rsdy3; }
            set { _rsdy3 = value; }
        }
        public static double rsdx4
        {
            get { return _rsdx4; }
            set { _rsdx4 = value; }
        }
        public static double rsdy4
        {
            get { return _rsdy4; }
            set { _rsdy4 = value; }
        }
        public static double rsdx5
        {
            get { return _rsdx5; }
            set { _rsdx5 = value; }
        }
        public static double rsdy5
        {
            get { return _rsdy5; }
            set { _rsdy5 = value; }
        }
        public static double rsdx6
        {
            get { return _rsdx6; }
            set { _rsdx6 = value; }
        }
        public static double rsdy6
        {
            get { return _rsdy6; }
            set { _rsdy6 = value; }
        }
        public static double rsdx7
        {
            get { return _rsdx7; }
            set { _rsdx7 = value; }
        }
        public static double rsdy7
        {
            get { return _rsdy7; }
            set { _rsdy7 = value; }
        }
        public static double rsdx8
        {
            get { return _rsdx8; }
            set { _rsdx8 = value; }
        }
        public static double rsdy8
        {
            get { return _rsdy8; }
            set { _rsdy8 = value; }
        }
        public static double rsdx9
        {
            get { return _rsdx9; }
            set { _rsdx9 = value; }
        }
        public static double rsdy9
        {
            get { return _rsdy9; }
            set { _rsdy9 = value; }
        }

        public static double lsx
        {
            get { return _lsx; }
            set { _lsx = value; }
        }
        public static double lsy
        {
            get { return _lsy; }
            set { _lsy = value; }
        }
        public static double lsx1
        {
            get { return _lsx1; }
            set { _lsx1 = value; }
        }
        public static double lsy1
        {
            get { return _lsy1; }
            set { _lsy1 = value; }
        }
        public static double lsx2
        {
            get { return _lsx2; }
            set { _lsx2 = value; }
        }
        public static double lsy2
        {
            get { return _lsy2; }
            set { _lsy2 = value; }
        }
        public static double lsx3
        {
            get { return _lsx3; }
            set { _lsx3 = value; }
        }
        public static double lsy3
        {
            get { return _lsy3; }
            set { _lsy3 = value; }
        }
        public static double lsx4
        {
            get { return _lsx4; }
            set { _lsx4 = value; }
        }
        public static double lsy4
        {
            get { return _lsy4; }
            set { _lsy4 = value; }
        }
        public static double lsx5
        {
            get { return _lsx5; }
            set { _lsx5 = value; }
        }
        public static double lsy5
        {
            get { return _lsy5; }
            set { _lsy5 = value; }
        }
        public static double lsx6
        {
            get { return _lsx6; }
            set { _lsx6 = value; }
        }
        public static double lsy6
        {
            get { return _lsy6; }
            set { _lsy6 = value; }
        }
        public static double lsx7
        {
            get { return _lsx7; }
            set { _lsx7 = value; }
        }
        public static double lsy7
        {
            get { return _lsy7; }
            set { _lsy7 = value; }
        }
        public static double lsx8
        {
            get { return _lsx8; }
            set { _lsx8 = value; }
        }
        public static double lsy8
        {
            get { return _lsy8; }
            set { _lsy8 = value; }
        }
        public static double lsx9
        {
            get { return _lsx9; }
            set { _lsx9 = value; }
        }
        public static double lsy9
        {
            get { return _lsy9; }
            set { _lsy9 = value; }
        }

        public static double lsdx
        {
            get { return _lsdx; }
            set { _lsdx = value; }
        }
        public static double lsdy
        {
            get { return _lsdy; }
            set { _lsdy = value; }
        }
        public static double lsdx1
        {
            get { return _lsdx1; }
            set { _lsdx1 = value; }
        }
        public static double lsdy1
        {
            get { return _lsdy1; }
            set { _lsdy1 = value; }
        }
        public static double lsdx2
        {
            get { return _lsdx2; }
            set { _lsdx2 = value; }
        }
        public static double lsdy2
        {
            get { return _lsdy2; }
            set { _lsdy2 = value; }
        }
        public static double lsdx3
        {
            get { return _lsdx3; }
            set { _lsdx3 = value; }
        }
        public static double lsdy3
        {
            get { return _lsdy3; }
            set { _lsdy3 = value; }
        }
        public static double lsdx4
        {
            get { return _lsdx4; }
            set { _lsdx4 = value; }
        }
        public static double lsdy4
        {
            get { return _lsdy4; }
            set { _lsdy4 = value; }
        }
        public static double lsdx5
        {
            get { return _lsdx5; }
            set { _lsdx5 = value; }
        }
        public static double lsdy5
        {
            get { return _lsdy5; }
            set { _lsdy5 = value; }
        }
        public static double lsdx6
        {
            get { return _lsdx6; }
            set { _lsdx6 = value; }
        }
        public static double lsdy6
        {
            get { return _lsdy6; }
            set { _lsdy6 = value; }
        }
        public static double lsdx7
        {
            get { return _lsdx7; }
            set { _lsdx7 = value; }
        }
        public static double lsdy7
        {
            get { return _lsdy7; }
            set { _lsdy7 = value; }
        }
        public static double lsdx8
        {
            get { return _lsdx8; }
            set { _lsdx8 = value; }
        }
        public static double lsdy8
        {
            get { return _lsdy8; }
            set { _lsdy8 = value; }
        }
        public static double lsdx9
        {
            get { return _lsdx9; }
            set { _lsdx9 = value; }
        }
        public static double lsdy9
        {
            get { return _lsdy9; }
            set { _lsdy9 = value; }
        }

        public static int fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }

        public static int ships
        {
            get { return _ships; }
            set { _ships = value; }
        }

        public static int score
        {
            get { return _score; }
            set { _score = value; }
        }

        public static int level
        {
            get { return _level; }
            set { _level = value; }
        }

        public static Rectangle rObstacle
        {
            get { return _rObstacle; }
            set { _rObstacle = value; }
        }
        public static Rectangle rObstacle1
        {
            get { return _rObstacle1; }
            set { _rObstacle1 = value; }
        }
        public static Rectangle rObstacle2
        {
            get { return _rObstacle2; }
            set { _rObstacle2 = value; }
        }
        public static Rectangle rObstacle3
        {
            get { return _rObstacle3; }
            set { _rObstacle3 = value; }
        }
        public static Rectangle rObstacle4
        {
            get { return _rObstacle4; }
            set { _rObstacle4 = value; }
        }
        public static Rectangle rObstacle5
        {
            get { return _rObstacle5; }
            set { _rObstacle5 = value; }
        }
        public static Rectangle rObstacle6
        {
            get { return _rObstacle6; }
            set { _rObstacle6 = value; }
        }
        public static Rectangle rObstacle7
        {
            get { return _rObstacle7; }
            set { _rObstacle7 = value; }
        }
        public static Rectangle rObstacle8
        {
            get { return _rObstacle8; }
            set { _rObstacle8 = value; }
        }
        public static Rectangle rObstacle9
        {
            get { return _rObstacle9; }
            set { _rObstacle9 = value; }
        }

        public static PictureBox pictureBox1
        {
            get { return _pictureBox1; }
            set { _pictureBox1 = value; }
        }
        public static PictureBox pictureBox2
        {
            get { return _pictureBox2; }
            set { _pictureBox2 = value; }
        }
        public static PictureBox pictureBox3
        {
            get { return _pictureBox3; }
            set { _pictureBox3 = value; }
        }
        public static PictureBox pictureBox4
        {
            get { return _pictureBox4; }
            set { _pictureBox4 = value; }
        }
        public static PictureBox pictureBox5
        {
            get { return _pictureBox5; }
            set { _pictureBox5 = value; }
        }
        public static PictureBox pictureBox6
        {
            get { return _pictureBox6; }
            set { _pictureBox6 = value; }
        }
        public static PictureBox pictureBox7
        {
            get { return _pictureBox7; }
            set { _pictureBox7 = value; }
        }
        public static PictureBox pictureBox8
        {
            get { return _pictureBox8; }
            set { _pictureBox8 = value; }
        }
        public static PictureBox pictureBox9
        {
            get { return _pictureBox9; }
            set { _pictureBox9 = value; }
        }
        public static PictureBox pictureBox10
        {
            get { return _pictureBox10; }
            set { _pictureBox10 = value; }
        }

        public static PictureBox pictureBox11
        {
            get { return _pictureBox11; }
            set { _pictureBox11 = value; }
        }
        public static PictureBox pictureBox12
        {
            get { return _pictureBox12; }
            set { _pictureBox12 = value; }
        }
        public static PictureBox pictureBox13
        {
            get { return _pictureBox13; }
            set { _pictureBox13 = value; }
        }
        public static PictureBox pictureBox14
        {
            get { return _pictureBox14; }
            set { _pictureBox14 = value; }
        }
        public static PictureBox pictureBox15
        {
            get { return _pictureBox15; }
            set { _pictureBox15 = value; }
        }
        public static PictureBox pictureBox16
        {
            get { return _pictureBox16; }
            set { _pictureBox16 = value; }
        }
        public static PictureBox pictureBox17
        {
            get { return _pictureBox17; }
            set { _pictureBox17 = value; }
        }
        public static PictureBox pictureBox18
        {
            get { return _pictureBox18; }
            set { _pictureBox18 = value; }
        }
        public static PictureBox pictureBox19
        {
            get { return _pictureBox19; }
            set { _pictureBox19 = value; }
        }
        public static PictureBox pictureBox20
        {
            get { return _pictureBox20; }
            set { _pictureBox20 = value; }
        }

        public static bool addOnExist
        {
            get { return _addOnExist; }
            set { _addOnExist = value; }
        }

        public static int addOnItem
        {
            get { return _addOnItem; }
            set { _addOnItem = value; }
        }

        public static SoundPlayer player
        {
            get { return _player; }
        }

        public static void GetPlayerSound(string wavFileName)
        {
            _player = new SoundPlayer(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Sound\\" + wavFileName);
        }
    }
}
