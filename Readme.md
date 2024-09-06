<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128630463/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E719)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - How to move data rows up and down


This example shows how to swap the focused row and its adjacent row (top or bottom).

```csharp
// Moves the focused row up.
private void button1_Click(object sender, System.EventArgs e) {
	DevExpress.XtraGrid.Views.Grid.GridView view = gridView1;
	view.GridControl.Focus();
	int index = view.FocusedRowHandle;
	if(index <= 0) return;
	DataRow row1 = view.GetDataRow(index);
	DataRow row2 = view.GetDataRow(index - 1);
	object val1 = row1[OrderFieldName];
	object val2 = row2[OrderFieldName];
	row1[OrderFieldName] = val2;
	row2[OrderFieldName] = val1;
	view.FocusedRowHandle = index - 1;
}
// Moves the focused row down.
private void button2_Click(object sender, System.EventArgs e) {
	DevExpress.XtraGrid.Views.Grid.GridView view = gridView1;
	view.GridControl.Focus();
	int index = view.FocusedRowHandle;
	if(index >= view.DataRowCount - 1) return;
	DataRow row1 = view.GetDataRow(index);
	DataRow row2 = view.GetDataRow(index + 1);
	object val1 = row1[OrderFieldName];
	object val2 = row2[OrderFieldName];
	row1[OrderFieldName] = val2;
	row2[OrderFieldName] = val1;
	view.FocusedRowHandle = index + 1;
}
```

## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))


## See Also

* [DevExpress WinForms Troubleshooting - Grid Control](https://go.devexpress.com/CheatSheets_WinForms_Examples_T934742.aspx)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-move-focused-row-up-down&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-move-focused-row-up-down&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
