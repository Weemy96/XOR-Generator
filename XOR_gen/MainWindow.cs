using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        lst_box("", false);//initialization treeview on start-up program
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    public TreeViewColumn hex_col = new TreeViewColumn();
    public ListStore hex_save = new ListStore(typeof(string));
    public CellRendererText namecell = new CellRendererText();

	//class initialization treeview
	private void lst_box(string x, bool y)
    {
        hex_col.Title = "ASCII DEC code";
        this.treeview1.AppendColumn(hex_col);
        this.treeview1.Model = hex_save;
        hex_col.PackStart(namecell, true);
        hex_col.AddAttribute(namecell, "text", 0);
        if (y)
        {
            hex_save.AppendValues(x);
        }
        else { }
    }

    //Generate ASCII(DEC) [btn_ran]
	protected void onClickRandom(object sender, EventArgs e)
	{
        Random random_ = new Random();

		try
		{
            if(hex_save.IterNChildren()==0)
            {
				for (int r = 1; r <= Convert.ToInt32(random_ascii.Text); r++)
				{
					int ascii_code = random_.Next(1, 256);
					lst_box(ascii_code.ToString(), true);
				}
			}
            else
            {
                hex_save.Clear();
				for (int r = 1; r <= Convert.ToInt32(random_ascii.Text); r++)
				{
					int ascii_code = random_.Next(1, 256);
					lst_box(ascii_code.ToString(), true);
				}
            }
		}
		catch (Exception c)
		{
			msg(1, c.ToString(), MessageType.Error);
		}
	}

    //press ENTER in ramdom number sprin button to generate ASCII(DEC) [random_ascii:Activated]
	private void press_enter_to_input(object sender, EventArgs e)
	{
		onClickRandom(this, new EventArgs());
	}

	//delete treeview row button [del_lst_btn]
	private void Delete_Select(object sender, EventArgs e)
	{
		del_lst_box_selected(hex_save);
	}

	//clear all treeview row, [clear_btn]
	private void clear_all_list(object sender, EventArgs e)
	{
		hex_save.Clear();
		txt_xor_string.Text = "";
		code_dec.Buffer.Text = "";
	}

	//generate xor [btn_gen]
	private void generate_xor(object sender, EventArgs e)
	{
		char[] enc_text = txt_enc.Text.ToCharArray();
		TreeIter iter;
		hex_save.GetIterFirst(out iter);
		string dec_code = "", lel = "";
		Int32[] hex_code = new Int32[hex_save.IterNChildren()];

		if (txt_enc.Text == "")
		{
			msg(1, "String to Confused must input.", MessageType.Error);
		}
		else if (hex_save.IterNChildren() == 0)
		{
			msg(1, "Must have some numbers in ASCII DEC Code", MessageType.Warning);
		}
		else
		{
			for (int x = 0; x < hex_save.IterNChildren(); x++)
			{
				hex_code[x] = Convert.ToInt32(hex_save.GetValue(iter, 0));
				hex_save.IterNext(ref iter);
			}

			try
			{
				foreach (var hex in enc_text)
				{
					Int32 hex_c = Convert.ToInt32(hex);
					for (int y = 0; y < hex_code.Length; y++)
					{
						hex_c ^= hex_code[y];
					}
					lel += hex_c.ToString() + " ";
				}
				txt_xor_string.Text = lel;

				for (int dec = hex_code.Length; dec > 0; dec--)
				{
					dec_code += "\tx ^= " + hex_code[dec - 1].ToString() + ";\n";
				}
				code_dec.Buffer.Text = "private void dec_x(string x)\n{\n" + dec_code + "\treturn x;\n}";
			}
			catch (Exception c)
			{
				msg(1, c.ToString(), MessageType.Error);
			}
		}
	}

    //Class delete selected row in treeview
    private void del_lst_box_selected(ListStore listStore)
    {
        TreeIter iter;
        TreePath[] treepart = treeview1.Selection.GetSelectedRows();
        if (treepart.Length != 0)
        {
            for (int i = treepart.Length; i > 0; i--)
            {
                listStore.GetIter(out iter, treepart[(i - 1)]);
                listStore.Remove(ref iter);
            }
        }
        else
        {
            msg(1, "Please select row to delete.", MessageType.Warning);
        }
    }

    //Message Dialog (Message Box) class
    public void msg(int num, string msg_, MessageType msg_icon)
    {
        
        MessageDialog err = new MessageDialog(this, DialogFlags.DestroyWithParent,
                                 MessageType.Error, ButtonsType.Close, "Program MessageDialog Error!");

        MessageDialog cust = new MessageDialog(this, DialogFlags.DestroyWithParent,
                                               msg_icon, ButtonsType.Close, msg_);

        switch (num)
        {
            case 1:
                cust.Run();
                cust.Destroy();
                break;

            default:
                err.Run();
                err.Destroy();
                break;
        }
    }
}
