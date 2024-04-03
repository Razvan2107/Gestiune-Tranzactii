using Laborator_14.Domain;
using Laborator_14.Repository;
using Laborator_14.UI;

namespace Laborator_14;

public class Program
{
    static void Main()
    {
        DocumentRepo documentRepo = new DocumentRepo("documente.txt");
        AchizitieRepo achizitieRepo = new AchizitieRepo("achizitii.txt");
        FacturaRepo facturaRepo = new FacturaRepo("facturi.txt", documentRepo, achizitieRepo);

        Service.Service service = new Service.Service(achizitieRepo, facturaRepo, documentRepo);
        
        Ui console = new Ui(service);
        console.Run();
    }
}