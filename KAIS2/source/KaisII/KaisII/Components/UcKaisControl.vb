
Imports KaisII.FormGenClasses
Public Interface UcKaisControl
    Property Field As Field
    ReadOnly Property Label As Label

    Sub SetToDefault()
    Function GetValue() As Object
    Sub SetLabelText(ByVal text As String)
    Sub SetDataSource(ByVal dataSource As Object)
    Sub SetValue(ByVal value As Object)

End Interface
