#! /bin/sh

# See https://unity3d.com/get-unity/download/archive
# to get download URLs
UNITY_DOWNLOAD_CACHE="$(pwd)/unity_download_cache"
UNITY_OSX_PACKAGE_URL="https://download.unity3d.com/download_unity/f2970305fe1c/MacEditorInstaller/Unity.pkg"
UNITY_ANDROID_TARGET_PACKAGE_URL="https://download.unity3d.com/download_unity/f2970305fe1c/MacEditorTargetInstaller/UnitySetup-Android-Support-for-Editor-2019.1.6f1.pkg"


# Downloads a file if it does not exist
download() {

	URL=$1
	FILE=`basename "$URL"`
	
	# Downloads a package if it does not already exist in cache
	if [ ! -e $UNITY_DOWNLOAD_CACHE/`basename "$URL"` ] ; then
		echo "$FILE does not exist. Downloading from $URL: "
		mkdir -p "$UNITY_DOWNLOAD_CACHE"
		curl -o $UNITY_DOWNLOAD_CACHE/`basename "$URL"` "$URL"
	else
		echo "$FILE Exists. Skipping download."
	fi
}

# Downloads and installs a package from an internet URL
install() {
	PACKAGE_URL=$1
	download $1

	echo "Installing `basename "$PACKAGE_URL"`"
	sudo installer -dumplog -package $UNITY_DOWNLOAD_CACHE/`basename "$PACKAGE_URL"` -target /
}

echo "Contents of Unity Download Cache:"
ls $UNITY_DOWNLOAD_CACHE

echo "Installing Unity..."
install $UNITY_OSX_PACKAGE_URL
install $UNITY_ANDROID_TARGET_PACKAGE_URL