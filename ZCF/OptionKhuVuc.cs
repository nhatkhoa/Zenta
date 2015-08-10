using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DevExpress.XtraEditors;


namespace ZCF
{
    public partial class OptionKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public int _khuVuc = 1;
        public OptionKhuVuc()
        {
            InitializeComponent();
            AcceptButton.DialogResult = DialogResult.OK;
            
            gcKhuVuc.DataSource = KhuVuc.GetKhuVuc();

        }

        private void gvKhuVuc_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _khuVuc = (int) gvKhuVuc.GetFocusedRowCellValue(ID);
            }
            catch{
                
            }
        }

       
    }
}