using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    internal class Program
    {
        static List<Article> stock = new List<Article>();

        static void Main(string[] args)
        {
            bool continuer = true;
            while (continuer)
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1. Rechercher un article par référence");
                Console.WriteLine("2. Ajouter un article au stock");
                Console.WriteLine("3. Supprimer un article par référence");
                Console.WriteLine("4. Modifier un article par référence");
                Console.WriteLine("5. Rechercher un article par nom");
                Console.WriteLine("6. Rechercher un article par intervalle de prix de vente");
                Console.WriteLine("7. Afficher tous les articles");
                Console.WriteLine("8. Quitter");
                Console.Write("Votre choix: ");
                int choix;
                if (int.TryParse(Console.ReadLine(), out choix))
                {
                    switch (choix)
                    {
                        case 1:
                            RechercherParReference();
                            break;
                        case 2:
                            AjouterArticle();
                            break;
                        case 3:
                            SupprimerArticle();
                            break;
                        case 4:
                            ModifierArticle();
                            break;
                        case 5:
                            RechercherParNom();
                            break;
                        case 6:
                            RechercherParPrix();
                            break;
                        case 7:
                            AfficherArticles();
                            break;
                        case 8:
                            continuer = false;
                            break;
                        default:
                            Console.WriteLine("Choix invalide.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrée invalide.");
                }
            }
        }
    }
        
        static void RechercherParReference()
    {
        Console.Write("Entrer la référence de l'article: ");
        int reference = int.Parse(Console.ReadLine());
        Article article = stock.Find(article => article.reference == reference);
        if (article != null)
        {
            Console.WriteLine(article):
        }else { Console.WriteLine("article not found")}
    }

    static void AjouterArticle()
    {
        Console.Write("Entrez la référence de l'article: ");
        int reference = int.Parse(Console.ReadLine());
        if (stock.Find(a => a.Reference == reference) != null)
        {
            Console.WriteLine("Une article avec cette référence existe déjà.");
            return;
        }

        Console.Write("Entrez le nom de l'article: ");
        string nom = Console.ReadLine();
        Console.Write("Entrez le prix de vente de l'article: ");
        double prixVente = double.Parse(Console.ReadLine());
        Console.Write("Entrez la quantité en stock de l'article: ");
        int quantiteStock = int.Parse(Console.ReadLine());

        stock.Add(new Article(reference, nom, prixVente, quantiteStock));
        Console.WriteLine("Article ajouté avec succès.");
    }
        }
   
