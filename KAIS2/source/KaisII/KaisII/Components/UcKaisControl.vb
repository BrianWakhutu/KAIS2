
Imports KaisII.FormGenClasses
Public Interface UcKaisControl
    Property Field As Field
    ReadOnly Property Label As Label

    Sub SetToDefault()
    Function GetSkipValue() As String
    Function GetRealValue() As Object
    Sub SetLabelText(ByVal text As String)
    Sub SetDataSource(ByVal dataSource As Object)

End Interface
