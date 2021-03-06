
// This file has been generated by the GUI designer. Do not modify.
namespace MonoGame.Tools.Pipeline
{
	public partial class TextEditorDialog
	{
		private global::Gtk.Label label2;
		
		private global::Gtk.Entry entry1;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoGame.Tools.Pipeline.TextEditorDialog
			this.Name = "MonoGame.Tools.Pipeline.TextEditorDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(4));
			// Internal child MonoGame.Tools.Pipeline.TextEditorDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.Spacing = 4;
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("label2");
			w1.Add (this.label2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(w1 [this.label2]));
			w2.Position = 0;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.entry1 = new global::Gtk.Entry ();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '●';
			w1.Add (this.entry1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(w1 [this.entry1]));
			w3.Position = 1;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.HeightRequest = 0;
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Only Letters, numbers, space and \"_\" are allowed.");
			w1.Add (this.label3);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(w1 [this.label3]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			// Internal child MonoGame.Tools.Pipeline.TextEditorDialog.ActionArea
			global::Gtk.HButtonBox w5 = this.ActionArea;
			w5.Name = "dialog1_ActionArea";
			w5.Spacing = 10;
			w5.BorderWidth = ((uint)(5));
			w5.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w6 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w5 [this.buttonCancel]));
			w6.Expand = false;
			w6.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.Sensitive = false;
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			w5.Add (this.buttonOk);
			global::Gtk.ButtonBox.ButtonBoxChild w7 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w5 [this.buttonOk]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 367;
			this.DefaultHeight = 143;
			this.label3.Hide ();
			this.Show ();
			this.Response += new global::Gtk.ResponseHandler (this.OnResponse);
			this.entry1.Changed += new global::System.EventHandler (this.OnEntry1Changed);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
