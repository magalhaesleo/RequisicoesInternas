using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Requisições_Internas.Domain.Features.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Infra.Exports
{
    public class PDFExport
    {
        public bool GenerateRequestReport(IRequestRepository repository, string filePath)
        {
            repository.GetAll().ToList();

            PdfWriter writer = new PdfWriter(filePath, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0));
            PdfDocument pdfDocument = new PdfDocument(writer);
            pdfDocument.SetTagged();
            Document document = new Document(pdfDocument);
            document.Add(new Paragraph("Relatorio requisições"));

            foreach (var item in repository.GetAll().ToList())
            {
                document.Add(new Paragraph("ID: " + item.Id + " Data requisição: " + item.DateRequest + " Status: " + item.Status + " Usuario: " + item.User.Name));
                foreach (var productsRequest in item.ProductsRequest)
                {
                    var p = new Paragraph("Produto: " + productsRequest.Product.Name + " Descrição: " + productsRequest.Product.Description + " Quantidade: "+productsRequest.Quantity);
                    p.SetMarginLeft(100);
                    document.Add(p);
                }
            }
            

            document.Close();

            return true;
        }
    }
}
