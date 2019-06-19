using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Requisições_Internas.Application.Features.Products;
using Requisições_Internas.Application.Features.Requests;
using Requisições_Internas.Domain.Features.Users;
using Requisições_Internas.Domain.Features.Requests;
using Requisições_Internas.Application.Features.Users;

namespace Requisições_Internas.WinApp.Features.Requests
{
    public partial class RequestControl : UserControl
    {
        IProductService _productService;
        IRequestService _requestService;
        IUserService _userService;
        User _user;
        BindingList<Request> _requests = new BindingList<Request>();
        public RequestControl(IProductService productService, IRequestService requestService, IUserService userService)
        {
            InitializeComponent();
            _productService = productService;
            _requestService = requestService;
            _userService = userService;
            dtgProducts.DataSource = _requests;
            dtgProducts.Columns["ProductsRequest"].Visible = false;
            dtgProducts.Columns["Id"].Visible = false;
        }

        public void SetUser(User user)
        {
            _user = user;
            if (_user.Group == Domain.Object_Values.UserGroup.Normal)
            {
                btnUpdateStatus.Visible = false;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddRequest addRequest = new AddRequest(_productService, _requestService, _user);
            addRequest.ShowDialog();
            UpdateListRequests();
        }

        public void UpdateListRequests()
        {
            List<Request> requests = new List<Request>();
            if (_user.Group == Domain.Object_Values.UserGroup.Normal)
            {
                requests.AddRange( _requestService.GetAll()
                    .Where(r => r.User.Id == _user.Id)
                    .ToList());
            }
            else
            {
                requests.AddRange(_requestService.GetAll().ToList());
            }

            _requests.Clear();
            foreach (var item in requests)
            {
                _requests.Add(item);
            }

            _requests.ResetBindings();
        }

        private void btnUpdateRequisition_Click(object sender, EventArgs e)
        {
            if (dtgProducts.SelectedRows.Count > 0)
            {
                Request request = _requestService.GetById(long.Parse(dtgProducts.SelectedRows[0].Cells["id"].Value.ToString()));
                AddRequest addRequest = new AddRequest(_productService, _requestService, _user, request);
                addRequest.Text = "Editar Requisição";
                addRequest.ShowDialog();
                UpdateListRequests();
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            Request request = _requestService.GetById(long.Parse(dtgProducts.SelectedRows[0].Cells["id"].Value.ToString()));
            UpdateRequestStatus updateRequestStatus = new UpdateRequestStatus(_requestService, _userService, request);
            updateRequestStatus.ShowDialog();
        }
    }
}
