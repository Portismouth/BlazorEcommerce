namespace BlazorEcommerce.Client.Pages
{
    public partial class Index : ComponentBase
    {
        [Parameter]
        public string CategoryUrl { get; set; }
        [Parameter]
        public string? SearchText { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            if (SearchText != null)
            {
                await ProductService.SearchProducts(SearchText);
            }
            else
            {
                await ProductService.GetProducts(CategoryUrl);
            }
        }
    }
}
