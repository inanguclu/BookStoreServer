using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreServer.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class mg5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCategories_Books_BookId",
                table: "BookCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCategories_Categories_CategoryId",
                table: "BookCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Books_BookId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Books_BookId",
                table: "ShoppingCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Users_UserId",
                table: "ShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderStatuses",
                table: "OrderStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCategories",
                table: "BookCategories");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "orders");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "categories");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "books");

            migrationBuilder.RenameTable(
                name: "ShoppingCarts",
                newName: "shopping_carts");

            migrationBuilder.RenameTable(
                name: "OrderStatuses",
                newName: "order_statuses");

            migrationBuilder.RenameTable(
                name: "BookCategories",
                newName: "book_categories");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "users",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "users",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "users",
                newName: "lastname");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "users",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Username",
                table: "users",
                newName: "ix_users_username");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Email",
                table: "users",
                newName: "ix_users_email");

            migrationBuilder.RenameColumn(
                name: "Raiting",
                table: "orders",
                newName: "raiting");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "orders",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "Price_Value",
                table: "orders",
                newName: "price_value");

            migrationBuilder.RenameColumn(
                name: "Price_Currency",
                table: "orders",
                newName: "price_currency");

            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "orders",
                newName: "comment");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "orders",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PaymentType",
                table: "orders",
                newName: "payment_type");

            migrationBuilder.RenameColumn(
                name: "PaymentNumber",
                table: "orders",
                newName: "payment_number");

            migrationBuilder.RenameColumn(
                name: "PaymentDate",
                table: "orders",
                newName: "payment_date");

            migrationBuilder.RenameColumn(
                name: "OrderNumber",
                table: "orders",
                newName: "order_number");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "orders",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "orders",
                newName: "book_id");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_BookId",
                table: "orders",
                newName: "ix_orders_book_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "categories",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "categories",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "categories",
                newName: "is_deleted");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "categories",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "books",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Summary",
                table: "books",
                newName: "summary");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "books",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "Price_Value",
                table: "books",
                newName: "price_value");

            migrationBuilder.RenameColumn(
                name: "Price_Currency",
                table: "books",
                newName: "price_currency");

            migrationBuilder.RenameColumn(
                name: "ISBN",
                table: "books",
                newName: "isbn");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "books",
                newName: "author");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "books",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "books",
                newName: "is_deleted");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "books",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "books",
                newName: "create_at");

            migrationBuilder.RenameColumn(
                name: "CoverImageUrl",
                table: "books",
                newName: "cover_image_url");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "shopping_carts",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "Price_Value",
                table: "shopping_carts",
                newName: "price_value");

            migrationBuilder.RenameColumn(
                name: "Price_Currency",
                table: "shopping_carts",
                newName: "price_currency");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "shopping_carts",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "shopping_carts",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "shopping_carts",
                newName: "book_id");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCarts_UserId",
                table: "shopping_carts",
                newName: "ix_shopping_carts_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCarts_BookId",
                table: "shopping_carts",
                newName: "ix_shopping_carts_book_id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "order_statuses",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "order_statuses",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "StatusDate",
                table: "order_statuses",
                newName: "status_date");

            migrationBuilder.RenameColumn(
                name: "OrderNumber",
                table: "order_statuses",
                newName: "order_number");

            migrationBuilder.RenameIndex(
                name: "IX_OrderStatuses_Status_OrderNumber",
                table: "order_statuses",
                newName: "ix_order_statuses_status_order_number");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "book_categories",
                newName: "category_id");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "book_categories",
                newName: "book_id");

            migrationBuilder.RenameIndex(
                name: "IX_BookCategories_CategoryId",
                table: "book_categories",
                newName: "ix_book_categories_category_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_users",
                table: "users",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_orders",
                table: "orders",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_categories",
                table: "categories",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_books",
                table: "books",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_shopping_carts",
                table: "shopping_carts",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_order_statuses",
                table: "order_statuses",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_book_categories",
                table: "book_categories",
                columns: new[] { "book_id", "category_id" });

            migrationBuilder.AddForeignKey(
                name: "fk_book_categories_books_book_id",
                table: "book_categories",
                column: "book_id",
                principalTable: "books",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_book_categories_categories_category_id",
                table: "book_categories",
                column: "category_id",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_orders_books_book_id",
                table: "orders",
                column: "book_id",
                principalTable: "books",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_shopping_carts_books_book_id",
                table: "shopping_carts",
                column: "book_id",
                principalTable: "books",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_shopping_carts_users_user_id",
                table: "shopping_carts",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_book_categories_books_book_id",
                table: "book_categories");

            migrationBuilder.DropForeignKey(
                name: "fk_book_categories_categories_category_id",
                table: "book_categories");

            migrationBuilder.DropForeignKey(
                name: "fk_orders_books_book_id",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "fk_shopping_carts_books_book_id",
                table: "shopping_carts");

            migrationBuilder.DropForeignKey(
                name: "fk_shopping_carts_users_user_id",
                table: "shopping_carts");

            migrationBuilder.DropPrimaryKey(
                name: "pk_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "pk_orders",
                table: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "pk_categories",
                table: "categories");

            migrationBuilder.DropPrimaryKey(
                name: "pk_books",
                table: "books");

            migrationBuilder.DropPrimaryKey(
                name: "pk_shopping_carts",
                table: "shopping_carts");

            migrationBuilder.DropPrimaryKey(
                name: "pk_order_statuses",
                table: "order_statuses");

            migrationBuilder.DropPrimaryKey(
                name: "pk_book_categories",
                table: "book_categories");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "orders",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "categories",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "books",
                newName: "Books");

            migrationBuilder.RenameTable(
                name: "shopping_carts",
                newName: "ShoppingCarts");

            migrationBuilder.RenameTable(
                name: "order_statuses",
                newName: "OrderStatuses");

            migrationBuilder.RenameTable(
                name: "book_categories",
                newName: "BookCategories");

            migrationBuilder.RenameColumn(
                name: "username",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "Users",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "ix_users_username",
                table: "Users",
                newName: "IX_Users_Username");

            migrationBuilder.RenameIndex(
                name: "ix_users_email",
                table: "Users",
                newName: "IX_Users_Email");

            migrationBuilder.RenameColumn(
                name: "raiting",
                table: "Orders",
                newName: "Raiting");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "Orders",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "price_value",
                table: "Orders",
                newName: "Price_Value");

            migrationBuilder.RenameColumn(
                name: "price_currency",
                table: "Orders",
                newName: "Price_Currency");

            migrationBuilder.RenameColumn(
                name: "comment",
                table: "Orders",
                newName: "Comment");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Orders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "payment_type",
                table: "Orders",
                newName: "PaymentType");

            migrationBuilder.RenameColumn(
                name: "payment_number",
                table: "Orders",
                newName: "PaymentNumber");

            migrationBuilder.RenameColumn(
                name: "payment_date",
                table: "Orders",
                newName: "PaymentDate");

            migrationBuilder.RenameColumn(
                name: "order_number",
                table: "Orders",
                newName: "OrderNumber");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Orders",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "book_id",
                table: "Orders",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "ix_orders_book_id",
                table: "Orders",
                newName: "IX_Orders_BookId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Categories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "is_deleted",
                table: "Categories",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "Categories",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Books",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "summary",
                table: "Books",
                newName: "Summary");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "Books",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "price_value",
                table: "Books",
                newName: "Price_Value");

            migrationBuilder.RenameColumn(
                name: "price_currency",
                table: "Books",
                newName: "Price_Currency");

            migrationBuilder.RenameColumn(
                name: "isbn",
                table: "Books",
                newName: "ISBN");

            migrationBuilder.RenameColumn(
                name: "author",
                table: "Books",
                newName: "Author");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Books",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "is_deleted",
                table: "Books",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "Books",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "create_at",
                table: "Books",
                newName: "CreateAt");

            migrationBuilder.RenameColumn(
                name: "cover_image_url",
                table: "Books",
                newName: "CoverImageUrl");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "ShoppingCarts",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "price_value",
                table: "ShoppingCarts",
                newName: "Price_Value");

            migrationBuilder.RenameColumn(
                name: "price_currency",
                table: "ShoppingCarts",
                newName: "Price_Currency");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ShoppingCarts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "ShoppingCarts",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "book_id",
                table: "ShoppingCarts",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "ix_shopping_carts_user_id",
                table: "ShoppingCarts",
                newName: "IX_ShoppingCarts_UserId");

            migrationBuilder.RenameIndex(
                name: "ix_shopping_carts_book_id",
                table: "ShoppingCarts",
                newName: "IX_ShoppingCarts_BookId");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "OrderStatuses",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "OrderStatuses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "status_date",
                table: "OrderStatuses",
                newName: "StatusDate");

            migrationBuilder.RenameColumn(
                name: "order_number",
                table: "OrderStatuses",
                newName: "OrderNumber");

            migrationBuilder.RenameIndex(
                name: "ix_order_statuses_status_order_number",
                table: "OrderStatuses",
                newName: "IX_OrderStatuses_Status_OrderNumber");

            migrationBuilder.RenameColumn(
                name: "category_id",
                table: "BookCategories",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "book_id",
                table: "BookCategories",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "ix_book_categories_category_id",
                table: "BookCategories",
                newName: "IX_BookCategories_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderStatuses",
                table: "OrderStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCategories",
                table: "BookCategories",
                columns: new[] { "BookId", "CategoryId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategories_Books_BookId",
                table: "BookCategories",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategories_Categories_CategoryId",
                table: "BookCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Books_BookId",
                table: "Orders",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Books_BookId",
                table: "ShoppingCarts",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Users_UserId",
                table: "ShoppingCarts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
