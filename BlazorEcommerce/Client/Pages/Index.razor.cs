namespace BlazorEcommerce.Client.Pages
{
    public partial class Index : ComponentBase
    {
        [Parameter]
        public string CategoryUrl { get; set; }
        [Parameter]
        public string? SearchText { get; set; }
        [Parameter]
        public int Page { get; set; } = 1;

        protected override async Task OnParametersSetAsync()
        {
            if (SearchText != null)
            {
                await ProductService.SearchProducts(SearchText, Page);
            }
            else
            {
                await ProductService.GetProducts(CategoryUrl);
            }
        }
    }
}
