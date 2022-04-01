using Amazon_.Models;
using Amazon_.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon_.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository authRepository;
        public AuthService(IAuthRepository authRepository)
        {
            this.authRepository = authRepository;
        }

        public Tuple<Response, string> Authenticate(UserCred userCred)
        {
            return authRepository.Authenticate(userCred);
        }

        public void AddCategory(Category category, string adminToken)
        {
            authRepository.AddCategory(category, adminToken);
        }

        public List<Category> GetCategories()
        {
            return authRepository.GetCategories();
        }

        public string AddProduct(Product product, string adminToken)
        {
            return authRepository.AddProduct(product, adminToken);
        }

        public Product GetProductById(int id)
        {
            return authRepository.GetProductById(id);
        }

        public List<Product> GetProducts()
        {
            return authRepository.GetProducts();
        }

        public string UpdateProduct(Product product, string adminToken)
        {
            return authRepository.UpdateProduct(product, adminToken);
        }

        public void DeleteProduct(int ProductId, string userToken)
        {
            authRepository.DeleteProduct(ProductId, userToken);
        }
    }
}
