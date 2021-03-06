
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox2;

	private global::Gtk.VBox vbox3;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Label label1;

	private global::Gtk.Entry txt_enc;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Label label2;

	private global::Gtk.SpinButton random_ascii;

	private global::Gtk.Button btn_ran;

	private global::Gtk.HBox hbox4;

	private global::Gtk.ScrolledWindow GtkScrolledWindow1;

	private global::Gtk.TreeView treeview1;

	private global::Gtk.VBox vbox4;

	private global::Gtk.Button del_lst_btn;

	private global::Gtk.Button clear_btn;

	private global::Gtk.HBox hbox3;

	private global::Gtk.Label label3;

	private global::Gtk.Entry txt_xor_string;

	private global::Gtk.Button btn_gen;

	private global::Gtk.VBox vbox1;

	private global::Gtk.Label label4;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView code_dec;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("XOR Generator");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		this.vbox2.BorderWidth = ((uint)(9));
		// Container child vbox2.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("String to Confused");
		this.hbox1.Add(this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.txt_enc = new global::Gtk.Entry();
		global::Gtk.Tooltips w2 = new Gtk.Tooltips();
		w2.SetTip(this.txt_enc, "Input text need to XOR.", "Input text need to XOR.");
		this.txt_enc.CanFocus = true;
		this.txt_enc.Name = "txt_enc";
		this.txt_enc.IsEditable = true;
		this.txt_enc.InvisibleChar = '●';
		this.hbox1.Add(this.txt_enc);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.txt_enc]));
		w3.Position = 1;
		this.vbox3.Add(this.hbox1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox1]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Random ASCII");
		this.hbox2.Add(this.label2);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label2]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.random_ascii = new global::Gtk.SpinButton(2D, 100D, 1D);
		w2.SetTip(this.random_ascii, "Range 1-100 only. To generate ASCII(DEC) in Random.", "Range 1-100 only. To generate ASCII(DEC) in Random.");
		this.random_ascii.CanFocus = true;
		this.random_ascii.Name = "random_ascii";
		this.random_ascii.Adjustment.PageIncrement = 10D;
		this.random_ascii.ClimbRate = 1D;
		this.random_ascii.Numeric = true;
		this.random_ascii.Value = 2D;
		this.hbox2.Add(this.random_ascii);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.random_ascii]));
		w6.Position = 1;
		w6.Padding = ((uint)(29));
		// Container child hbox2.Gtk.Box+BoxChild
		this.btn_ran = new global::Gtk.Button();
		this.btn_ran.WidthRequest = 100;
		this.btn_ran.CanFocus = true;
		this.btn_ran.Name = "btn_ran";
		this.btn_ran.UseUnderline = true;
		this.btn_ran.Label = global::Mono.Unix.Catalog.GetString("Random");
		this.hbox2.Add(this.btn_ran);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.btn_ran]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		this.vbox3.Add(this.hbox2);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox2]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.treeview1 = new global::Gtk.TreeView();
		this.treeview1.CanFocus = true;
		this.treeview1.Name = "treeview1";
		this.GtkScrolledWindow1.Add(this.treeview1);
		this.hbox4.Add(this.GtkScrolledWindow1);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.GtkScrolledWindow1]));
		w10.Position = 0;
		// Container child hbox4.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.del_lst_btn = new global::Gtk.Button();
		this.del_lst_btn.CanFocus = true;
		this.del_lst_btn.Name = "del_lst_btn";
		this.del_lst_btn.UseUnderline = true;
		this.del_lst_btn.Label = global::Mono.Unix.Catalog.GetString("Delete");
		this.vbox4.Add(this.del_lst_btn);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.del_lst_btn]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.clear_btn = new global::Gtk.Button();
		this.clear_btn.WidthRequest = 100;
		this.clear_btn.CanFocus = true;
		this.clear_btn.Name = "clear_btn";
		this.clear_btn.UseUnderline = true;
		this.clear_btn.Label = global::Mono.Unix.Catalog.GetString("Clear All");
		this.vbox4.Add(this.clear_btn);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.clear_btn]));
		w12.Position = 2;
		w12.Expand = false;
		w12.Fill = false;
		this.hbox4.Add(this.vbox4);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox4]));
		w13.Position = 1;
		w13.Expand = false;
		w13.Fill = false;
		this.vbox3.Add(this.hbox4);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox4]));
		w14.Position = 2;
		this.vbox2.Add(this.vbox3);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox3]));
		w15.Position = 0;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("XOR Confuseded (ASCII DEC)");
		this.hbox3.Add(this.label3);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label3]));
		w16.Position = 0;
		w16.Expand = false;
		w16.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.txt_xor_string = new global::Gtk.Entry();
		this.txt_xor_string.CanFocus = true;
		this.txt_xor_string.Name = "txt_xor_string";
		this.txt_xor_string.IsEditable = true;
		this.txt_xor_string.InvisibleChar = '●';
		this.hbox3.Add(this.txt_xor_string);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.txt_xor_string]));
		w17.Position = 1;
		// Container child hbox3.Gtk.Box+BoxChild
		this.btn_gen = new global::Gtk.Button();
		this.btn_gen.WidthRequest = 100;
		this.btn_gen.CanFocus = true;
		this.btn_gen.Name = "btn_gen";
		this.btn_gen.UseUnderline = true;
		this.btn_gen.Label = global::Mono.Unix.Catalog.GetString("Generate");
		this.hbox3.Add(this.btn_gen);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.btn_gen]));
		w18.Position = 2;
		w18.Expand = false;
		w18.Fill = false;
		this.vbox2.Add(this.hbox3);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox3]));
		w19.Position = 1;
		w19.Expand = false;
		w19.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.Xalign = 0F;
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Code for decode:");
		this.vbox1.Add(this.label4);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label4]));
		w20.Position = 0;
		w20.Expand = false;
		w20.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.code_dec = new global::Gtk.TextView();
		this.code_dec.CanFocus = true;
		this.code_dec.Name = "code_dec";
		this.code_dec.Editable = false;
		this.GtkScrolledWindow.Add(this.code_dec);
		this.vbox1.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
		w22.Position = 1;
		this.vbox2.Add(this.vbox1);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox1]));
		w23.PackType = ((global::Gtk.PackType)(1));
		w23.Position = 2;
		this.Add(this.vbox2);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 637;
		this.DefaultHeight = 467;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.random_ascii.Activated += new global::System.EventHandler(this.press_enter_to_input);
		this.btn_ran.Clicked += new global::System.EventHandler(this.onClickRandom);
		this.del_lst_btn.Clicked += new global::System.EventHandler(this.Delete_Select);
		this.clear_btn.Clicked += new global::System.EventHandler(this.clear_all_list);
		this.btn_gen.Clicked += new global::System.EventHandler(this.generate_xor);
	}
}
