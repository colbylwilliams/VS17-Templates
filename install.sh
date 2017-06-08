# /bin/bash

clean=true
reset=false

while [[ $# > 0 ]]; do
    lowerI="$(echo $1 | awk '{print tolower($0)}')"
    case $lowerI in
        -r|--reset-installs)
            reset=true
            ;;
        -s|--skip-clean)
            clean=false
            ;;
        -h|--help)
            echo "Options:"
            echo "  -r|--reset-installs      Removes all custom installed templates before installing"
            echo "  -s|--skip-clean          Skips deleting the bin obj packages and userprefs (they will be included in the templates)"
            echo "  -h|--help                Display this help message"
            exit 0
            ;;
        *)
            break
            ;;
    esac

    shift
done

echo ""
echo "Making sure dotnet cli is installed..."

if [ ! -d /usr/local/share/dotnet/sdk ]; then
	echo "Hold up..."
    echo "  dotnet isn't installed, you must install dotnet core to use dotnet new command"
    echo "  Go do that and try again"
    exit 0
fi

echo "Found dotnet cli at /usr/local/share/dotnet"
echo ""

root=$PWD

if [ "$clean" = true ]; then

	echo "Dleaning template solutions..."

	echo "Deleting the bin, obj and packages directories"

	# find all directories that match name flags recursivily and remove
	find "$root" \( -name "obj" -o -name "bin" -o -name "packages" \) -type d -exec rm -rf {} +

	echo "Deleting .userprefs file"

	# find all files that match name flags recursivily and remove
	find "$root" -type f -name "*.userprefs" -exec rm -rf {} +

	echo "Dinished cleaning template solutions"
else

	echo "Skipping clean per user request"

fi

echo ""

# install templates

if [ "$reset" = true ]; then

	echo "Removing installed templates..."

	dotnet new --debug:reinit
	
	echo "Finished removing installed templates"
	echo ""
fi

echo "Installing iOS templates..."
echo ""

echo "Installing SinglePage..."
echo ""
dotnet new --install "$root/iOS/SinglePage"
echo ""
echo "Finished installing SinglePage"
echo ""

echo ""
echo "Installing TableViewTemplate..."
echo ""
dotnet new --install "$root/iOS/TableViewTemplate"
echo ""
echo "Finished installing TableViewTemplate"
echo ""

echo ""
echo "Installing CollectionViewTemplate..."
echo ""
dotnet new --install "$root/iOS/CollectionViewTemplate"
echo ""
echo "Finished installing CollectionViewTemplate"
echo ""

echo ""
dotnet new Xamarin -l
echo "Finished installing templates, you're all set!"
echo ""
echo "Example:"
echo "  dotnet new iostableview -n AwesomeApp"
echo ""

