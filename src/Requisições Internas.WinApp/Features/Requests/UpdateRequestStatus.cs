using Requisições_Internas.Application.Features.Requests;
using Requisições_Internas.Application.Features.Users;
using Requisições_Internas.Domain.Features.Requests;
using Requisições_Internas.Domain.Object_Values;
using Requisições_Internas.WinApp.Features.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Requisições_Internas.WinApp.Features.Requests
{
    public partial class UpdateRequestStatus : Form
    {
        Request _request;
        IRequestService _requestService;
        IUserService _userService;
        public UpdateRequestStatus(IRequestService requestService, IUserService userService, Request request)
        {
            InitializeComponent();
            _request = request;
            cmbStatus.Items.Add(Status.Aprovado);
            cmbStatus.Items.Add(Status.EntregueEditado);
            cmbStatus.Items.Add(Status.Entregue);
            cmbStatus.Items.Add(Status.Negado);
            cmbStatus.Items.Add(Status.Aberto);

            cmbStatus.SelectedItem = _request.Status;
            _requestService = requestService;
            _userService = userService;
        }

       

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            var status = (Status)cmbStatus.SelectedItem; ;
            if (status == Status.Aberto || status == Status.Negado)
            {
                _request.AcceptanceDate = null;
                _request.DeliveryDate = null;
            }                    

            if (status == Status.Entregue || status == Status.EntregueEditado)
            {
                UserLogin userLogin = new UserLogin(_userService);
                userLogin.lblTitle.Text = "Validar Informações";
                userLogin.txtUser.Visible = false;
                userLogin.lblUser.Visible = false;
                userLogin.SetRequest(_request);

                userLogin.ShowDialog();
                if (!userLogin.Authenticated)
                {
                    this.Close();
                    return;
                }

                if (_request.AcceptanceDate == null)
                {
                    _request.AcceptanceDate = DateTime.Now;
                }

                _request.DeliveryDate = DateTime.Now;
            }

            if (status == Status.Aprovado)
            {
                _request.AcceptanceDate = DateTime.Now;
                _request.DeliveryDate = null;
            }

            _request.Status = status;
            _requestService.Update(_request);
            _requestService.Update(_request);
            this.Close();
        }
    }
}
