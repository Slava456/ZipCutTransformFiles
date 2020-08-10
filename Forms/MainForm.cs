using System;
using System.Windows.Forms;
using System.Threading;
using ZipCutTransformFiles.Classes;

namespace ZipCutTransformFiles.Forms
{
    public partial class MainForm : Form
    {
        private CustTextBoxClass _ctbHeight = new CustTextBoxClass();

        private CustTextBoxClass _ctbWidth = new CustTextBoxClass();

        private CustPanelClass _cpnlDrop;

        private CustPanelClass _cpnlDropOut;

        private TakerAndBuilderDataClass _tbdc = new TakerAndBuilderDataClass();

        private CollectionsClassForWF _ccfwf = new CollectionsClassForWF(new CollectionsClass());

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _cpnlDrop = new CustPanelClass(lblTop);
            _cpnlDropOut = new CustPanelClass(lblBot);
            pnfForPnlDrop.Controls.Add(_cpnlDrop);
            pnlForPnlDropOut.Controls.Add(_cpnlDropOut);
            pnlForCTBWidth.Controls.Add(_ctbWidth);
            pnlForCTBHeight.Controls.Add(_ctbHeight);
            _cpnlDrop.DragEnter += new DragEventHandler(_cpnlDrop.Pnl_DragEnter);
            _cpnlDrop.DragDrop += new DragEventHandler(_cpnlDrop.Pnl_DragDrop);
            _cpnlDropOut.DragEnter += new DragEventHandler(_cpnlDropOut.Pnl_DragEnter);
            _cpnlDropOut.DragDrop += new DragEventHandler(_cpnlDropOut.Pnl_DragDrop);
        }

        private void btGo_Click(object sender, EventArgs e)
        {
            if (!isCorrectlyDigit())
            {
                _ctbWidth.Clear();
                _ctbHeight.Clear();
                _ = MessageBox.Show("Введите повторно новый размер изображений");
            }
            else
            {
                ToDoTransform();
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            _ctbWidth.Clear();
            _ctbHeight.Clear();
            lblTop.Text = ClassWithStaticParam.DragDir;
            lblBot.Text = ClassWithStaticParam.DragDirOut;
            lbl.Visible = false;
            lbl.Text = string.Empty;
            pb.Value = 0;
            _cpnlDrop.ClearDir();
            _cpnlDropOut.ClearDir();
            _tbdc.ClearInfoAboutDirs();
            _ccfwf.ClearAllCollectoins();
        }

        private bool isCorrectlyDigit()
        {
            return _ctbWidth.isCorrectDigit() && _ctbHeight.isCorrectDigit();
        }

        private void ToDoTransform()
        {
            try
            {
                _tbdc.SetDirectoryIn(_cpnlDrop.GiveDirectory());
                _tbdc.SetDirectoryOut(_cpnlDropOut.GiveDirectory());
                if (_tbdc.isDirsNotNullOrEmpty() && _tbdc.isDirsOther())
                {
                    lbl.Visible = true;
                    string strWithError = string.Empty;
                    this.Invoke(new ThreadStart(delegate
                    {
                        _tbdc.TakeData(_ctbWidth.GiveValFromCTB(), _ctbHeight.GiveValFromCTB(), _ccfwf);
                        _ccfwf.CreateDirsOut();
                        pb.Maximum = _tbdc.GetGiveCountFileVal();
                        pb.Value = 0;
                        _ccfwf.TransformAndSaveFiles(pb, lbl);
                        strWithError = _ccfwf.GiveStringWithErrorFiles();
                    }));
                    if (!string.IsNullOrEmpty(strWithError))
                    {
                        _ = MessageBox.Show("Не удалось преобразовать файлы: " + strWithError);
                    }
                    else
                    {
                        _ = MessageBox.Show("Все преобразования выполнены");
                    }
                }
                else
                {
                    _ = MessageBox.Show("Ошибка директорий", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.ToString());
            }
            finally
            {
                Clear();
            }
        }
    }
}
