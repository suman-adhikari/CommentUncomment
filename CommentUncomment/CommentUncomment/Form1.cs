using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CommentUncomment
{
    public partial class Form1 : Form
    {
        private string _path,_text,_subtext;
        private int _start, _end;
        public Form1()
        {
            InitializeComponent();
         
        }

        public void Initiallization()
        {
           _path = tbPath.Text;
           _text = File.ReadAllText(_path);
           _start = _text.IndexOf("//R", StringComparison.Ordinal);
           _end = _text.IndexOf("//RE", StringComparison.Ordinal);
           _subtext = _text.Substring(_start, _end - _start);


        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            if (tbPath.Text != "")
            {
                Initiallization();

                string[] st = tbComment.Text.Split(Environment.NewLine.ToCharArray());
                List<string> commentList = st.ToList();
                List<string> unCommentList = new List<string>();
                foreach (var item in commentList)
                {
                    unCommentList.Add("//" + item);
                }

                string changedText = SingleComment(_subtext, commentList, unCommentList);
                _text = _text.Replace(_text.Substring(_start, _end - _start), changedText);
                File.WriteAllText(_path, _text);
               
                string msg = NoOfCorrection(_subtext, commentList);
                lblMsg.Text = @"Code Commented" + Environment.NewLine + msg ;
            }
            else
            {
                MessageBox.Show(@"Please provide Path");
            }
        }

        private void btnUncomment_Click(object sender, EventArgs e)
        {
            if (tbPath.Text != "")
            {
                Initiallization();
                string[] st = tbUncomment.Text.Split(Environment.NewLine.ToCharArray());
                List<string> commentList = st.ToList();
                List<string> unCommentList = new List<string>();
                foreach (var item in commentList)
                {
                    unCommentList.Add("//" + item);
                }

                string changedText = SingleUncomment(_subtext, unCommentList);
                _text = _text.Replace(_text.Substring(_start, _end - _start), changedText);
                File.WriteAllText(_path, _text);
                string msg = NoOfCorrection(_subtext, commentList);
                lblMsg.Text = @"Code UnCommented" + Environment.NewLine + msg;
            }
            else
            {
                MessageBox.Show(@"Please provide the Path");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Initiallization();

            string[] st = tbComment.Text.Split(Environment.NewLine.ToCharArray());
            List<string> removeList = st.ToList();

            string changedText = RemoveLine(_subtext, removeList);
            _text = _text.Replace(_text.Substring(_start, _end - _start), changedText);
            File.WriteAllText(_path, _text);
            string msg = NoOfCorrection(_subtext, removeList);
            lblMsg.Text = @"Code Removed" + Environment.NewLine + msg;
        }

        public string SingleComment(string subtext, List<string> commentList, List<string> unCommentList)
        {
            string uncommentedSubtext = SingleUncomment(subtext, unCommentList);
            foreach (var item in commentList)
            {
                uncommentedSubtext = uncommentedSubtext.Replace(item, "//" + item);
            }
            return uncommentedSubtext;
        }

        public string SingleUncomment(string subtext, List<string> commentList)
        {
            foreach (var item in commentList)
            {
                subtext = subtext.Replace(item, item.Replace("//", ""));
            }
            return subtext;
        }

        public string RemoveLine(string subtext, List<string> commentList)
        {
            foreach (var item in commentList)
            {
                subtext = subtext.Replace(item, "");
            }
            return subtext;
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string temp = tbComment.Text;
            tbComment.Text = tbUncomment.Text;
            tbUncomment.Text = temp;
        }

        private string NoOfCorrection(string subtext, List<string> commentList)
        {
            int count = 0;
            string st = "";
            foreach (var item in commentList)
            {
                count = stringOccurance(subtext,item);
                st += count + " occurance of " + item + Environment.NewLine;
            }
            return st;
        }

        private int stringOccurance(string src, string tar)
        {
            int count = 0;
            for (int i = 0; i < src.Length; i++)
            {
                var flag = src.IndexOf(tar, i);
                if (flag >= 0)
                {
                    count++;
                    i = flag;
                }
            }
            return count;
        }


    }
}
