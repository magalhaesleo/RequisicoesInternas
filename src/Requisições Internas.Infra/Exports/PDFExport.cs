using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Requisições_Internas.Domain.Features.Invoices;
using Requisições_Internas.Domain.Features.Products;
using Requisições_Internas.Domain.Features.Providers;
using Requisições_Internas.Domain.Features.Requests;
using Requisições_Internas.Domain.Features.Users;
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
            PdfWriter writer = new PdfWriter(filePath + ".pdf", new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0));
            PdfDocument pdfDocument = new PdfDocument(writer);
            pdfDocument.SetTagged();
            Document document = new Document(pdfDocument);
            document.Add(new Paragraph("Relatorio Requisições"));

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

        public bool GenerateProvidersReport(IProviderRepository providerRepository, string filePath)
        {
            PdfWriter writer = new PdfWriter(filePath + ".pdf", new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0));
            PdfDocument pdfDocument = new PdfDocument(writer);
            pdfDocument.SetTagged();
            Document document = new Document(pdfDocument);
            document.Add(new Paragraph("Relatorio Fornecedores"));

            foreach (var item in providerRepository.GetAll().ToList())
            {
                document.Add(new Paragraph("ID: " + item.Id + " Nome: " + item.Name + " CNPJ: " + item.CNPJ + " Telephone: " + item.Telephone));
            }

            document.Close();

            return true;
        }

        public bool GenerateProductsReport(IProductRepository productRepository, string filePath)
        {
            PdfWriter writer = new PdfWriter(filePath + ".pdf", new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0));
            PdfDocument pdfDocument = new PdfDocument(writer);
            pdfDocument.SetTagged();
            Document document = new Document(pdfDocument);
            document.Add(new Paragraph("Relatorio Produtos"));

            foreach (var item in productRepository.GetAll().ToList())
            {
                document.Add(new Paragraph("ID: " + item.Id + " Nome: " + item.Name + " Unidade: " + item.Unit + " Descrição: " + item.Description));
            }

            document.Close();

            return true;
        }

        public bool GenerateUsersReport(IUserRepository userRepository, string filePath)
        {
            PdfWriter writer = new PdfWriter(filePath+".pdf", new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0));
            PdfDocument pdfDocument = new PdfDocument(writer);
            pdfDocument.SetTagged();
            Document document = new Document(pdfDocument);
            document.Add(new Paragraph("Relatorio Fornecedores"));

            foreach (var item in userRepository.GetAll().ToList())
            {
                document.Add(new Paragraph("ID: " + item.Id + " Nome: " + item.Name + " Departamento: " + item.Department + " Aniversario: " + item.Birth.ToShortDateString()));
            }

            document.Close();

            return true;
        }

        public bool GenerateInvoicesReport(IInvoiceRepository invoiceRepository, string filePath)
        {
            PdfWriter writer = new PdfWriter(filePath + ".pdf", new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0));
            PdfDocument pdfDocument = new PdfDocument(writer);
            pdfDocument.SetTagged();
            Document document = new Document(pdfDocument);
            document.Add(new Paragraph("Relatorio Notas fiscais"));

            foreach (var item in invoiceRepository.GetAll().ToList())
            {
                document.Add(new Paragraph("ID: " + item.Id + " Fornecedor: " + item.Provider + " Data Entrada: " + item.Date + " Valor: " + item.Value));
                foreach (var product in item.Products)
                {
                    var p = new Paragraph("Produto: " + product.Name + " Valor: " + product.Description + " Unidade: " + product.Unit);
                    p.SetMarginLeft(100);
                    document.Add(p);
                }
            }

            document.Close();

            return true;
        }
    }
}
