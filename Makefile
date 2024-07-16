all:
	dotnet build

clean:
	rm -rf Migrations/*
	mariadb -u root -proot -e "drop database product_catalogue; create database product_catalogue"

reset: clean
	dotnet ef migrations add InitialMigration
	dotnet ef database update
