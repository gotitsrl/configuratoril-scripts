

AddReference "Autodesk.iLogic.UiBuilder.dll"
'Richiesta di immissione dei parametri
'Prompt for user input

Dim res As Autodesk.iLogic.UiBuilder.FormReturn 

res = iLogicForm.Show("PARAMETRI", FormMode.Modal)

'Verifica risposta utente
If res.Result.ToString() = "OK" Then

    'Esecuzione delle regole di configurazione
    'Run the confiuration rules
    iLogicVb.RunRule("GC_Execute")
    'Sostituzione dei componenti
    'Replace component with existing ones
    iLogicVb.RunRule("GC_Replace")  

Else

    MsgBox("Configurazione annullata dall'utente")  
    Dim doc = ThisDoc.Document
    doc.Close(True) 

End If
