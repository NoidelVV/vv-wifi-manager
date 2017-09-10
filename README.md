# VV Wi-Fi Manager
Software per la gestione della connessione Wi-Fi degli Studenti del Liceo.
## Utilizzo
Il software permette di visualizzare gli studenti che hanno fatto richiesta di attivazione della connessione, di scannerizzare e attivare richieste in attesa e di visualizzare gli utenti connessi al sistema.
## Descrizione Files
Il codice non è commentato in quanto inteso per un deployment rapido.  
Di seguito viene fornita una descrizione dei file contenuti nel progetto.
### AuthorizeUserCode.cs
Form per la scansione delle richieste di attivazione.
### AuthorizeUserView.cs
Form che mostra le informazioni relative alla richiesta di attivazione scannerizzata.
### CorpConnection.cs
Classe per la connessione al sistema di SSO Corp.
### Main.cs
Form principale che avvia tutte le connessioni ai diversi database.  
Viene impostato come MDIContainer di tutti i Forms.
### MainLogin.cs
Form per il Login a Corp. Il livello di accesso richiesto è "wifi".  
I membri non possono accedere se non al livello come "admin".
### NausicaaSQL.cs
Classe per la connessione al database MySQL presente su Nausicaa. Contiene anche le funzioni per l'esecuzione delle query e delle non-query (senza un ritorno da parte di MySQL).
### RequestsList.cs
Elenca tutte le richieste di attivazione della connessione.  
Le richieste non possono essere attivate tramite questo Form ma vanno prima scannerizzate.
### Users.cs
Classe per ottenere le informazioni su un utente.
### UsersList.cs
Elenca tutti gli utenti attivi sulla rete Wi-Fi del Liceo.
### WifiUsers.cs
Classe per la gestione degli utenti in tutte le aree del software
