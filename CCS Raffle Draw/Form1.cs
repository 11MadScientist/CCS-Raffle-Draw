using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CCS_Raffle_Draw
{

    
    
    public partial class Form1 : Form
    {
        //soundtracks
        /// <sound>
        String path = Path.Combine(Environment.CurrentDirectory);
        SoundPlayer bean = new SoundPlayer(@"S:\+Crazy+\C#\CCS Raffle Draw\raffle img\raffle\bean.wav");
        SoundPlayer open1 = new SoundPlayer(@"S:\+Crazy+\C#\CCS Raffle Draw\raffle img\raffle\nande.wav");
        SoundPlayer ching = new SoundPlayer(@"S:\+Crazy+\C#\CCS Raffle Draw\raffle img\raffle\ching.wav");
        SoundPlayer fire = new SoundPlayer(@"S:\+Crazy+\C#\CCS Raffle Draw\raffle img\raffle\Firework.wav");
        SoundPlayer summer = new SoundPlayer(@"S:\+Crazy+\C#\CCS Raffle Draw\raffle img\raffle\summer.wav");
        //SoundPlayer tada = new SoundPlayer(@"D:\+Crazy+\Visual Studio\CCS Raffle Draw\raffle img\raffle\tada.wav");
        SoundPlayer dota = new SoundPlayer(@"S:\+Crazy+\C#\CCS Raffle Draw\raffle img\raffle\open1.wav");
        SoundPlayer dotaloop = new SoundPlayer(@"S:\+Crazy+\C#\CCS Raffle Draw\raffle img\raffle\open2.wav");
        /// <tracks>

        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Thread t1 = new Thread(RaffleLoad);
            t1.Start();
            summer.PlayLooping();
            


        }
        /// Used for jumping letters animation
        public void letterPop(Button L)
        {
            
            for (int i = 115; i >= 3; i--)
            {
                L.Invoke(new Action(() => L.Location = new Point(L.Location.X, i)));
                Thread.Sleep(1);
                if (i < 30)
                {
                    Thread.Sleep(20);
                }

            }
            //Thread.Sleep(500);

            for (int i = 3; i <= 115; i++)
            {
                L.Invoke(new Action(() => L.Location = new Point(L.Location.X, i)));
                // Thread.Sleep(1);

            }

            for (int x = 0; x < 2; x++)
            {

                for (int i = 115; i >= 70; i--)
                {
                    L.Invoke(new Action(() => L.Location = new Point(L.Location.X, i)));
                    // Thread.Sleep(1);

                }
                Thread.Sleep(200);

                for (int i = 70; i <= 115; i++)
                {
                    L.Invoke(new Action(() => L.Location = new Point(L.Location.X, i)));
                    // Thread.Sleep(1);

                }

            }
        }
        private int count = 0;

        /// <summary>
        /// used for showing the letters at the exact location
        /// </summary>
        public void letters()
        {
           
                    try
                    {

                        switch (count)
                        {
                            case 211:
                                picLeft.Invoke(new Action(() => picLeft.Show()));
                                break;

                            case 316:
                                R.Invoke(new Action(() => R.Show()));
                                letterPop(R);
                                
                                break;

                            case 448:
                                A.Invoke(new Action(() => A.Show()));
                                letterPop(A);
                                break;

                            case 571:
                                F1.Invoke(new Action(() => F1.Show()));
                                letterPop(F1);
                                break;

                            case 695:
                                F2.Invoke(new Action(() => F2.Show()));
                                letterPop(F2);
                                break;

                            case 808:
                                L.Invoke(new Action(() => L.Show()));
                                letterPop(L);
                                break;

                            case 949:
                                E.Invoke(new Action(() => E.Show()));
                                letterPop(E);
                                break;

                            case 1053:
                                picRight.Invoke(new Action(() => picRight.Show()));
                                break;


                        }

                        Thread.Sleep(1);
                    }
                    catch (Exception) { MessageBox.Show("Errrrrr"); }

        }/// <summary>
        /// used for count updating and for the moving of giftbox
        /// </summary>
        public void RaffleLoad()
        {
            
            while (true)
            {
                //forward!!
                for (count = 0; count < 1177; count++)
                {
                    try
                    {
                        picGiftBox.Invoke(new Action(() => picGiftBox.Location = new Point(count, 73)));

                        switch (count)
                        {
                            case 211:
                                Thread thrd = new Thread(letters);
                                thrd.Start();
                                //picLeft.Invoke(new Action(() => picLeft.Show()));
                                break;

                            case 316:
                                thrd = new Thread(letters);
                                thrd.Start();
                                //R.Invoke(new Action(() => R.Show()));
                                break;

                            case 448:
                                thrd = new Thread(letters);
                                thrd.Start();
                                //A.Invoke(new Action(() => A.Show()));
                                break;

                            case 571:
                                thrd = new Thread(letters);
                                thrd.Start();
                                //F1.Invoke(new Action(() => F1.Show()));
                                break;

                            case 695:
                                thrd = new Thread(letters);
                                thrd.Start();
                                //F2.Invoke(new Action(() => F2.Show()));
                                break;

                            case 808:
                                thrd = new Thread(letters);
                                thrd.Start();
                                //L.Invoke(new Action(() => L.Show()));

                                break;

                            case 949:
                                thrd = new Thread(letters);
                                thrd.Start();
                                //E.Invoke(new Action(() => E.Show()));

                                break;

                            case 1053:
                                thrd = new Thread(letters);
                                thrd.Start();
                                //picRight.Invoke(new Action(() => picRight.Show()));
                                break;


                        }

                        Thread.Sleep(7);
                    }
                    catch (Exception) { MessageBox.Show("Errrrrr"); }

                  
                }
                
                piclucky.Invoke(new Action(() => piclucky.Show()));
                pic2020.Invoke(new Action(() => pic2020.Show()));
                //box jump
                for (int x = 0; x < 5; x++)
                {

                    for (int i = 73; i>=3; i--)
                    {
                        picGiftBox.Invoke(new Action(() => picGiftBox.Location = new Point(1177, i)));
                        
                         //Thread.Sleep(1);

                    }
                    Thread.Sleep(1000);

                    for (int i = 3; i <= 73; i++)
                    {
                        picGiftBox.Invoke(new Action(() => picGiftBox.Location = new Point(1177, i)));
                        //Thread.Sleep(1);

                    }

                }
                pic2020.Invoke(new Action(() => pic2020.Hide()));

                //reverse mode



                for (int i = 1177; i > 0; i--)
                {
                    try
                    {
                        R.Invoke(new Action(() => picGiftBox.Location = new Point(i, 73)));



                        switch (i)
                        {
                            case 211:
                                picLeft.Invoke(new Action(() => picLeft.Hide()));
                                break;

                            case 316:
                                R.Invoke(new Action(() => R.Hide()));
                                break;

                            case 448:
                                A.Invoke(new Action(() => A.Hide()));
                                break;

                            case 571:
                                F1.Invoke(new Action(() => F1.Hide()));
                                break;

                            case 695:
                                F2.Invoke(new Action(() => F2.Hide()));
                                break;

                            case 808:
                                L.Invoke(new Action(() => L.Hide()));

                                break;

                            case 949:
                                E.Invoke(new Action(() => E.Hide()));

                                break;

                            case 1053:
                                picRight.Invoke(new Action(() => picRight.Hide()));
                                break;


                        }

                        Thread.Sleep(5);
                    }
                    catch (Exception) { MessageBox.Show("Errrrrr"); }



                }
                piclucky.Invoke(new Action(() => piclucky.Hide()));
               


            }


            


        }

        
        /// <summary>
        /// when roulette is picked
        /// </summary>
        private void picRoulette_Click_1(object sender, EventArgs e)
        {
            picRoulette.Enabled = false;
            picleftfire.Enabled = false;
            picrightfire.Enabled = false;
            piclucky.Enabled = false;
            // piclightfromheaven.Enabled = true;
            pnlDraw.Show();
            AnimateNum();
            //Thread thr1 = new Thread(AnimateNum);
            //thr1.Start();
            
        }


        ///draw animation
        
        public void AnimateNum()
        {
            
            id1.Hide();
            id2.Hide();
            id3.Hide();
            id4.Hide();
            id5.Hide();
            id6.Hide();
            id7.Hide();
            id8.Hide();
            txtcountdown.Invoke(new Action(()=> txtcountdown.BackColor = Color.White));
            rafflefireL.Invoke(new Action(()=> rafflefireL.Enabled = false));
            rafflefireL.Invoke(new Action(() => rafflefireL.Hide())); 
            raffleFireR.Invoke(new Action(() => raffleFireR.Enabled = false));
            raffleFireR.Invoke(new Action(() => raffleFireR.Hide()));
            time = 0;
            pos = 0;
            Thread thr1 = new Thread(rand);
            thr1.Start();

            

            picLottery.Enabled = true;
            picLottery.Show();
            timer1.Start();

            






        }
        private int time = 0;
        private int pos = 0;
        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (time == 0)
                dotaloop.PlayLooping();
            if (pos < 8)
            {
                btnBigball.Text = id[7 - pos].ToString();
                btnBigball.Update();
            }
            
            time++;
            if (time == 5)
            {
                ching.Play();
                picLottery.Image = Properties.Resources.poof;
                
            }
            
            else if (time == 6)
            {
                picLottery.Enabled = false;
                picLottery.Hide();
                picLottery.Image = Properties.Resources.lottery;
                

                switch (pos)
                {
                    case 0:
                        pic1.Enabled = true;
                        pic1.Show();
                        break;

                    case 1:
                        pic2.Enabled = true;
                        pic2.Show();
                        break;

                    case 2:
                        pic3.Enabled = true;
                        pic3.Show();
                        break;

                    case 3:
                        pic4.Enabled = true;
                        pic4.Show();
                        break;

                    case 4:
                        pic5.Enabled = true;
                        pic5.Show();
                        break;

                    case 5:
                        pic6.Enabled = true;
                        pic6.Show();
                        break;

                    case 6:
                        pic7.Enabled = true;
                        pic7.Show();
                        break;

                    case 7:
                        pic8.Enabled = true;
                        pic8.Show();
                        break;

                    
                }

            }

            else if (time == 9)
            {
                switch (pos)
                {
                    case 0:
                        id1.Show();
                        pic1.Enabled = false ;
                        pic1.Hide();
                        break;

                    case 1:
                        id2.Show();
                        pic2.Enabled = false;
                        pic2.Hide();
                        break;

                    case 2:
                        id3.Show();
                        pic3.Enabled = false;
                        pic3.Hide();
                        break;

                    case 3:
                        id4.Show();
                        pic4.Enabled = false;
                        pic4.Hide();
                        break;

                    case 4:
                        id5.Show();
                        pic5.Enabled = false;
                        pic5.Hide();
                        break;

                    case 5:
                        id6.Show();
                        pic6.Enabled = false;
                        pic6.Hide();
                        break;

                    case 6:
                        id7.Show();
                        pic7.Enabled = false;
                        pic7.Hide();
                        timer1.Interval = 1000;
                        break;

                    case 7:
                        id8.Show();
                        pic8.Enabled = false;
                        pic8.Hide();
                        break;

                    


                }
                pos++;

                if (pos < 8)
                {
                    time = 0;
                    picLottery.Enabled = true;
                    picLottery.Show();
                }

                else
                {

                    
                    //tada.Play();
                    //Thread.Sleep(2000);
                    fire.Play();
                    raffleFireR.Enabled = true;
                    raffleFireR.Show();
                    rafflefireL.Enabled = true;
                    rafflefireL.Show();
                   



                }
                
                
                
            }
            
            if (time == 17)
            {
                
                pnlWinner.Visible = true;
                pnlWinner.Enabled = true;
                bean.Play();
                pnlWinner.Show();
                sec = 15;
                txtcountdown.Text = sec.ToString();
                txtcountdown.Update();
                countdown.Start();
                timer1.Stop();
                disableGift();
                
                
            }
        }

        int sec = 15;
        private void countdown_Tick(object sender, EventArgs e)
        {
            
            if (sec == 0)
            {
                txtcountdown.BackColor = Color.Red;
                countdown.Stop();
            }
            
            

            txtcountdown.Text = sec.ToString();
            txtcountdown.Update();
            sec--;
            
        }


        private int[] id = new int[8];
        public void rand()
        {
            connection.connection.DB();
            string str = "select * from ccsStudents";
            function.f.datagridfill(str, dataStudents);
            connection.connection.con.Close();

            int lim = dataStudents.RowCount;
            
            
            int idNum = 0;
            
            int randNum = 0;
            Random random = new Random();
            randNum = random.Next(0,lim);
            
            
            //MessageBox.Show(randNum + "");
            //MessageBox.Show(lim+"");
            
            idNum = int.Parse(dataStudents.Rows[randNum].Cells[0].Value.ToString());
            lblName.Invoke(new Action(()=> lblName.Text = dataStudents.Rows[randNum].Cells[1].Value.ToString()));
            

            connection.connection.DB();
            str = "delete from ccsStudents where id = "+idNum+" ";
            SqlCommand cmd = new SqlCommand(str, connection.connection.con);
            cmd.ExecuteNonQuery();
            connection.connection.con.Close();

            for (int i = 0; i < 8; i++)
            {
                id[i] = (idNum%10);
                idNum /= 10;
            }
            id1.Invoke(new Action(() => id1.Text = id[7].ToString()));
            id1.Invoke(new Action(() => id2.Text = id[6].ToString()));
            id1.Invoke(new Action(() => id3.Text = id[5].ToString()));
            id1.Invoke(new Action(() => id4.Text = id[4].ToString()));
            id1.Invoke(new Action(() => id5.Text = id[3].ToString()));
            id1.Invoke(new Action(() => id6.Text = id[2].ToString()));
            id1.Invoke(new Action(() => id7.Text = id[1].ToString()));
            id1.Invoke(new Action(() => id8.Text = id[0].ToString()));

            

        }

        private void btnClaim_Click(object sender, EventArgs e)
        {
            bean.Stop();
            timer1.Interval = 300;

            enableGift();
            countdown.Stop();
            pnlWinner.Enabled = false;
            pnlWinner.Visible = false;
            pnlDraw.Hide();
            pnlWinner.Hide();


            picRoulette.Enabled = true;
            picleftfire.Enabled = true;
            
            picrightfire.Enabled = true;
            piclucky.Enabled = true;

            SoundPlayer opening = new SoundPlayer();
            open1.PlayLooping();
        }

        private void btnredraw_Click(object sender, EventArgs e)
        {
            bean.Stop();
            timer1.Interval = 300;
            enableGift();
            countdown.Stop();
            pnlWinner.Enabled = false;
            pnlWinner.Visible = false;
            pnlWinner.Hide();
            pnlDraw.Show();
            AnimateNum();
        }

        public void disableGift()
        {   

            picGiftBox.Enabled = false;
            picGiftBox.Visible = false;

            pic2020.Enabled = false;
            pic2020.Visible = false;
            picuwin.Enabled = true;
            picuwin.Visible = true;

            picupleft.Enabled = true;
            picupleft.Visible = true;
            picupleft.Show();
            picupright.Enabled = true;
            picupright.Visible = true;
            picupright.Show();

        }

        public void enableGift()
        {
            picGiftBox.Enabled = true;
            picGiftBox.Visible = true;
           

            picuwin.Enabled = false;
            picuwin.Visible = false;

            picupleft.Enabled = false;
            picupleft.Visible = false;
            
            picupright.Enabled = false;
            picupright.Visible = false;


        }

        private void picupleft_Click(object sender, EventArgs e)
        {

        }
    }
}
