#!/usr/bin/env bash
set -ex

build_output="/tmp/build-output"
artifacts_path="./artifacts"
version=$1

mkdir -p $build_output
mkdir -p $artifacts_path

# compile apps 
(cd ClientsService && dotnet publish  --configuration Release --output $build_output/clients/ClientsService/bin/Release/netcoreapp3.1/publish)
(cd InventoryService && dotnet publish  --configuration Release --output $build_output/inventory/InventoryService/bin/Release/netcoreapp3.1/publish)

# bundle cf manifest with app
cp manifest-clients-staging.yml $build_output/clients/
cp manifest-clients-production.yml $build_output/clients/
cp manifest-inventory-staging.yml $build_output/inventory/
cp manifest-inventory-production.yml $build_output/inventory/


# build artifacts
tar -cvzf $artifacts_path/clients-service-$version.tgz --directory=$build_output/clients --remove-files . 
tar -cvzf $artifacts_path/inventory-service-$version.tgz --directory=$build_output/inventory --remove-files .
