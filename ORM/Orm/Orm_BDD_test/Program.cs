
using Orm_basefirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm_BDD_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int fin = 0;
            while (fin == 0)
            {
                
                Console.WriteLine("1- Avion");
                Console.WriteLine("2- Aeroport");
                Console.WriteLine("3- Client");
                Console.WriteLine("4- Baggage");
                Console.WriteLine("5- Billet");
                Console.WriteLine("6- Embarquement");
                Console.WriteLine("7- Employé");
                Console.WriteLine("8- Incident");
                Console.WriteLine("9- Maintenance");
                Console.WriteLine("10- Navigant");
                Console.WriteLine("11- Sol");
                Console.WriteLine("12- Tarif");
                Console.WriteLine("13- Vol");
                Console.WriteLine("14- Voyage");
                Console.WriteLine("0- Sortie");
                Console.WriteLine("Choisissez un élément dans la liste suivante :");
                string choix = Console.ReadLine();
                if(choix == "0")
                {
                    fin = 1;
                }
                if(choix == "1")
                {
                    using (var db = new ProjetBDD2Entities())
                    {
                        Console.WriteLine("Entrez le modèle");
                        string modele = Console.ReadLine();
                        Console.WriteLine("Entrez la disponibilité (true/false)");
                        string disponible = Console.ReadLine();
                        Console.WriteLine("Entrez les places economique");
                        string Eco = Console.ReadLine();
                        Console.WriteLine("Entrez les places Premiere");
                        string Premiere = Console.ReadLine();
                        Console.WriteLine("Entrez les places Premium");
                        string Premium = Console.ReadLine();
                        Console.WriteLine("Entrez les places Business");
                        string Busi = Console.ReadLine();
                        Console.WriteLine("Entrez le nombre d'équipage");
                        string equipage = Console.ReadLine();
                        Console.WriteLine("Entrez false si il n'a pas de proprietaire sinon True");
                        string proprietaire = Console.ReadLine();
                        Console.WriteLine("Entrez le code Aita de l'aeroport lié");
                        string Aita = Console.ReadLine();
                        Avion avion = new Avion()
                        {
                            Modele = modele,
                            Disponible = Convert.ToBoolean(disponible),
                            NbPlaceEconomique =Convert.ToInt32( Eco),
                            NbPlaceBusiness = Convert.ToInt32(Busi),
                            NbPlacePremiere = Convert.ToInt32(Premiere),
                            NbPlacePremium = Convert.ToInt32(Premium),
                            NbPlaceEquipege = Convert.ToInt32(equipage),
                            Proprietaire = Convert.ToBoolean(proprietaire),
                            CodeAeroport = Aita
                        };
                        db.Avions.Add(avion);
                        db.SaveChanges();
                        Console.WriteLine("Ajout pris en compte !");

                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                if(choix == "2")
                {
                    using (var db = new ProjetBDD2Entities())
                    {
                        Console.WriteLine("Entrez le code AITA");
                        string AITA = Console.ReadLine();
                        Console.WriteLine("Entrez le nom");
                        string nom = Console.ReadLine();
                        Console.WriteLine("Entrez l'adresse");
                        string adresse = Console.ReadLine();
                        Console.WriteLine("Entrez la ville");
                        string ville = Console.ReadLine();
                        Console.WriteLine("Entrez le pays");
                        string pays = Console.ReadLine();
                        Aeroport aeroport = new Aeroport()
                        {
                            CodeAITA = AITA,
                            Nom = nom,
                            Adresse =adresse,
                            Ville =ville,
                            Pays = pays,
                        };
                        db.Aeroports.Add(aeroport);
                        db.SaveChanges();
                        Console.WriteLine("Ajout pris en compte !");

                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                if(choix == "3")
                {
                    using (var db = new ProjetBDD2Entities())
                    {
                        Console.WriteLine("Entrez votre prénom");
                        string prenom = Console.ReadLine();
                        Console.WriteLine("Entrez votre nom");
                        string nom = Console.ReadLine();
                        Console.WriteLine("Entrez votre date de naissance sous la forme 'aaaa-mm-jj'");
                        string datenaiss = Console.ReadLine();
                        Client client = new Client()
                        {
                            Prenom = prenom,
                            Nom = nom,
                            DateNaiss = datenaiss
                        };
                        db.Clients.Add(client);
                        db.SaveChanges();
                        Console.WriteLine("Ajout pris en compte !");

                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                if(choix == "4")
                {
                    using (var db = new ProjetBDD2Entities())
                    {
                        Console.WriteLine("Entrez le poids");
                        string poids = Console.ReadLine();
                        Console.WriteLine("Entrez le tarrif");
                        string tarif = Console.ReadLine();
                        Console.WriteLine("Entrez l'id du client");
                        string client = Console.ReadLine();
                        Console.WriteLine("Entrez l'id du voyage");
                        string voyage = Console.ReadLine();
                        Console.WriteLine("Entrez l'id du billet");
                        string billet = Console.ReadLine();

                        Baggage baggage = new Baggage()
                        {
                           Poids_Kg_ = Convert.ToDouble(poids),
                           Tarifs = Convert.ToDecimal( tarif),
                           IdClient = Convert.ToInt32( client),
                           IdVoyages = Convert.ToInt32( voyage),
                           IdBillet = Convert.ToInt32( billet)
                        };
                        db.Baggages.Add(baggage);
                        db.SaveChanges();
                        Console.WriteLine("Ajout pris en compte !");

                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                if(choix == "5")
                {
                    using (var db = new ProjetBDD2Entities())
                    {
                        
                        Console.WriteLine("Entrez l'in du tarrif");
                        string tarif = Console.ReadLine();
                        Console.WriteLine("Entrez l'in du voyage");
                        string voyage = Console.ReadLine();
                        Console.WriteLine("Entrez l'id du client");
                        string client = Console.ReadLine();
                        Console.WriteLine("Entrez le prix du billet a l'achat");
                        string prix = Console.ReadLine();
                        Console.WriteLine("Entrez false ou true si il y a une réduction ou non");
                        string reduction = Console.ReadLine();

                        Billet billet = new Billet()
                        {
                           IdTarifs = Convert.ToInt32( tarif),
                           IdVoyages = Convert.ToInt32( voyage),
                           IdClient = Convert.ToInt32( client),
                           PrixPendantAchat = Convert.ToInt32( prix),
                           Reduction = Convert.ToBoolean(reduction)
                        };
                        db.Billets.Add(billet);
                        db.SaveChanges();
                        Console.WriteLine("Ajout pris en compte !");

                        Console.ReadKey();
                        Console.Clear();
                    }

                }
                if (choix == "6")
                {
                    using (var db = new ProjetBDD2Entities())
                    {
                        Console.WriteLine("Entrez l'id du client");
                        string client = Console.ReadLine();
                        Console.WriteLine("Entrez l'id du vol");
                        string vol = Console.ReadLine();
                       

                        Embarquement embarquement = new Embarquement()
                        {
                         IdClient = Convert.ToInt32(client),
                         idVol = Convert.ToInt32(vol),
                        };
                        db.Embarquements.Add(embarquement);
                        db.SaveChanges();
                        Console.WriteLine("Ajout pris en compte !");

                        Console.ReadKey();
                        Console.Clear();
                    }

                }
                if (choix == "7")
                {
                    using (var db = new ProjetBDD2Entities())
                    {

                        Console.WriteLine("Entrez le nom");
                        string nom = Console.ReadLine();
                        Console.WriteLine("Entrez le prénom");
                        string  prenom = Console.ReadLine();
                        Console.WriteLine("Entrez la date de naissance");
                        string datenaiss = Console.ReadLine();
                        Console.WriteLine("Entrez la date d'embauche");
                        string dateEmbauche = Console.ReadLine();
                        Console.WriteLine("Entrez false ou true si il possede le permis piste ou non");
                        string permis = Console.ReadLine();

                        Employe employe = new Employe()
                        {
                            Nom = nom,
                            Prenom = prenom,
                            DateNaiss = datenaiss,
                            DateEmbauche = dateEmbauche,
                            PermisVehiculePiste = Convert.ToBoolean(permis)
                        };
                        db.Employes.Add(employe);
                        db.SaveChanges();
                        Console.WriteLine("Ajout pris en compte !");

                        Console.ReadKey();
                        Console.Clear();
                    }

                }
                if (choix == "8")
                {
                    using (var db = new ProjetBDD2Entities())
                    {

                        Console.WriteLine("Entrez l'indice de gravité (int)");
                        string gravite = Console.ReadLine();
                        Console.WriteLine("Entrez un commentaire");
                        string commentaire = Console.ReadLine();
                        Console.WriteLine("Entrez la date");
                        string date = Console.ReadLine();
                        Console.WriteLine("Entrez l'id de l'employé");
                        string employe = Console.ReadLine();
                        Console.WriteLine("Entrez l'id de l'avion");
                        string avion = Console.ReadLine();
                        Console.WriteLine("Entrez l'id de la maintenance");
                        string maintenance = Console.ReadLine();

                        Incident incident = new Incident()
                        {
                           IndiceGravite = Convert.ToInt32(gravite),
                           Commentaire = commentaire,
                           Date = Convert.ToDateTime(date),
                           idEmploye = Convert.ToInt32(employe),
                           idAvion = Convert.ToInt32(avion),
                           IdMaintenance = Convert.ToInt32(maintenance)
                            
                        };
                        db.Incidents.Add(incident);
                        db.SaveChanges();
                        Console.WriteLine("Ajout pris en compte !");

                        Console.ReadKey();
                        Console.Clear();
                    }

                }
                if (choix == "9")
                {
                    using (var db = new ProjetBDD2Entities())
                    {

                        Console.WriteLine("Entrez le nom du chef d'équipe");
                        string nom = Console.ReadLine();
                        Console.WriteLine("Entrez l'id d'un employé");
                        string employe = Console.ReadLine();
                        Console.WriteLine("Entrez la date du début prevu");
                        string debutprevu = Console.ReadLine();
                        Console.WriteLine("Entrez la date de fin prevu");
                        string finprevu = Console.ReadLine();
                        Console.WriteLine("Entrez la date du début reel");
                        string debutreel = Console.ReadLine();
                        Console.WriteLine("Entrez la date de fin reel");
                        string finreele = Console.ReadLine();
                       

                        Maintenance maintenance = new Maintenance()
                        {
                            NomChefEquipe = nom,
                            idEmployee = Convert.ToInt32(employe),
                            DateDebutPrevue = Convert.ToDateTime(debutprevu),
                            DateFinPrevue = Convert.ToDateTime(finprevu),
                            DateDebutReelle = Convert.ToDateTime(debutreel),
                            DateFinReelle = Convert.ToDateTime(finreele),

                        };
                        db.Maintenances.Add(maintenance);
                        db.SaveChanges();
                        Console.WriteLine("Ajout pris en compte !");

                        Console.ReadKey();
                        Console.Clear();
                    }

                }
                if (choix == "10")
                {
                    using (var db = new ProjetBDD2Entities())
                    {

                        Console.WriteLine("Entrez le nom du poste");
                        string nomPoste = Console.ReadLine();
                        Console.WriteLine("Entrez true/false si il y a un pilote");
                        string pilote = Console.ReadLine();
                        Console.WriteLine("Entrez true/false si il y a un co-pilote");
                        string coPilote = Console.ReadLine();
                        Console.WriteLine("Entrez true/false si il y a une hotesse");
                        string hotesse = Console.ReadLine();


                        Naviguant naviguant = new Naviguant()
                        {
                            NomPoste = nomPoste,
                            Pilote = Convert.ToBoolean(pilote),
                            CoPilote = Convert.ToBoolean(coPilote),
                            Hotesse = Convert.ToBoolean(hotesse),
                        };
                        db.Naviguants.Add(naviguant);
                        db.SaveChanges();
                        Console.WriteLine("Ajout pris en compte !");

                        Console.ReadKey();
                        Console.Clear();
                    }

                }
                if (choix == "11")
                {
                    using (var db = new ProjetBDD2Entities())
                    {

                        Console.WriteLine("Entrez le nom du poste");
                        string nomPoste = Console.ReadLine();
                        Console.WriteLine("Entrez le code AITA de l'aeroport");
                        string Aita = Console.ReadLine();
                       


                        Sol sol = new Sol()
                        {
                           NomPoste = nomPoste,
                           CodeAeroport = Aita,
                        };
                        db.Sols.Add(sol);
                        db.SaveChanges();
                        Console.WriteLine("Ajout pris en compte !");

                        Console.ReadKey();
                        Console.Clear();
                    }

                }
                if (choix == "12")
                {
                    using (var db = new ProjetBDD2Entities())
                    {

                        Console.WriteLine("Entrez le type de tarif");
                        string typetarif = Console.ReadLine();
                        Console.WriteLine("Entrez la classe");
                        string classe = Console.ReadLine();
                        Console.WriteLine("Entrez le prix");
                        string prix = Console.ReadLine();
                        Console.WriteLine("Entrez l'id du voyage");
                        string voyage = Console.ReadLine();



                        Tarif tarif = new Tarif()
                        {
                            TypeTarif = typetarif,
                            Classe = classe,
                            Prix = Convert.ToInt32( prix),
                            IdVoyages = Convert.ToInt32( voyage),
                        };
                        db.Tarifs.Add(tarif);
                        db.SaveChanges();
                        Console.WriteLine("Ajout pris en compte !");

                        Console.ReadKey();
                        Console.Clear();
                    }

                }
                if (choix == "13")
                {
                    using (var db = new ProjetBDD2Entities())
                    {

                        Console.WriteLine("Entrez le code de l'aeroport de depart");
                        string aeroportdepart = Console.ReadLine();
                        Console.WriteLine("Entrez le code de l'aeroport d'arrivee prevu");
                        string aeroportarriveeprevu = Console.ReadLine();
                        Console.WriteLine("Entrez le code de l'aeroport d'arrivee reel");
                        string aeroportarriveereel = Console.ReadLine();
                        Console.WriteLine("Entrez la date de depart prevu");
                        string datedepartprevu= Console.ReadLine();
                        Console.WriteLine("Entrez la date de depart reele");
                        string departreel = Console.ReadLine();
                        Console.WriteLine("Entrez la date d'arrivee prevu");
                        string arriveeprevu = Console.ReadLine();
                        Console.WriteLine("Entrez la date d'arrivee reele");
                        string arriveereele = Console.ReadLine();
                        Console.WriteLine("Entrez la reference de la ligne");
                        string reference = Console.ReadLine();
                        Console.WriteLine("Entrez la reference du vol");
                        string referenceVol = Console.ReadLine();
                        Console.WriteLine("Entrez la distance");
                        string distance = Console.ReadLine();
                        Console.WriteLine("Entrez le temps de vol prévu");
                        string volprevu= Console.ReadLine();
                        Console.WriteLine("Entrez le temps de vol réel");
                        string volreel = Console.ReadLine();
                        Console.WriteLine("Entrez le nombre d'employé");
                        string nbemploye = Console.ReadLine();
                        Console.WriteLine("Entrez le nombre de place restante");
                        string nbplacerestante = Console.ReadLine();
                        Console.WriteLine("Entrez le nombre de place restante business");
                        string nbplacebusi = Console.ReadLine();
                        Console.WriteLine("Entrez le nombre de place restante premiere");
                        string placePremiere = Console.ReadLine();
                        Console.WriteLine("Entrez le nombre de place restante economique");
                        string placeEco = Console.ReadLine();
                        Console.WriteLine("Entrez le nombre de place restante premium");
                        string placePremium = Console.ReadLine();
                        Console.WriteLine("Entrez l'id du pilote");
                        string pilote = Console.ReadLine();
                        Console.WriteLine("Entrez l'id du co-pilote");
                        string copilote = Console.ReadLine();
                        Console.WriteLine("Entrez l'id due l'hotesse");
                        string hotesse = Console.ReadLine();
                        

                        Vol vol = new Vol()
                        {
                          AeroportDepart = aeroportdepart,
                          AeroportArriveePrevue = aeroportarriveeprevu,
                          AeroportArriveeReel = aeroportarriveereel,
                          DateDepartPrevue =Convert.ToDateTime( datedepartprevu),
                          DateDepartReel = Convert.ToDateTime( departreel),
                          DateArriveePrevue = Convert.ToDateTime( arriveeprevu),
                          DateArriveeReel = Convert.ToDateTime( arriveereele),
                          ReferenceLigne = reference,
                          ReferenceVol = referenceVol,
                          Distance = distance,
                          TempsVolPrevue_heure_ = volprevu.ParseTime(),
                          TempsVolReel_heure_ = volreel.ParseTime(),
                          nbEmployee = Convert.ToInt32(nbemploye),
                          NbPlaceRestante = Convert.ToInt32(nbplacerestante),
                          NbPlaceRestanteBusiness = Convert.ToInt32(nbplacebusi),
                          NbPlaceRestanteEconomique =Convert.ToInt32( placeEco),
                          NbPlaceRestantePremiere =Convert.ToInt32(placePremiere),
                          NbPlaceRestantePremium =Convert.ToInt32( placePremium),
                          idPilote =Convert.ToInt32( pilote),
                          idCopilote = Convert.ToInt32(copilote),
                          idHotesse = Convert.ToInt32(hotesse),

                        };
                        db.Vols.Add(vol);
                        db.SaveChanges();
                        Console.WriteLine("Ajout pris en compte !");

                        Console.ReadKey();
                        Console.Clear();
                    }

                }
                if (choix == "14")
                {
                    using (var db = new ProjetBDD2Entities())
                    {

                        Console.WriteLine("Entrez le nom du voyage");
                        string nom = Console.ReadLine();
                        Console.WriteLine("Entrez l'id de l'avion");
                        string avion = Console.ReadLine();
                        


                        Voyage voyage= new Voyage()
                        {
                            Nom = nom,
                            IdAvions =Convert.ToInt32(avion)
                        };
                        db.Voyages.Add(voyage);
                        db.SaveChanges();
                        Console.WriteLine("Ajout pris en compte !");

                        Console.ReadKey();
                        Console.Clear();
                    }

                }

            }
           
        }
    }
}
