//Richiesta di immissione dei parametri
//Prompt for user input

let res = iLogicUI.RunMainForm();

//Verifica risposta utente
if(res==DialogResult.OK)
{
    //Esecuzione delle regole di configurazione
    //Run the confiuration rules
    JsLogic.RunRule("GC_Execute");
    //Sostituzione dei componenti
    //Replace component with existing ones
    JsLogic.RunRule("GC_Replace") ;  

}
else
{

    MsgBox("Configurazione annullata dall'utente");
    ThisDoc.Close(true);

}

