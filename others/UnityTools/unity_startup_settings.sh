BLUE='\033[1;34m'
GREEN='\033[1;32m'
NC='\033[0m' # No Color
echo -e "${BLUE}===== Creating folders ... =====${NC}"
mkdir Assets/2D/
mkdir Assets/2D/Atlas/
mkdir Assets/2D/Textures/
mkdir Assets/3D/
mkdir Assets/3D/Materials/
mkdir Assets/3D/Models/
mkdir Assets/3D/Shaders/
mkdir Assets/3D/Animations/
mkdir Assets/ExternalAssets/
mkdir Assets/Prefabs/
mkdir Assets/Scripts/
mkdir Assets/Scripts/Editor/
mkdir Assets/Audio/
echo -e "${GREEN}===== Folders created =====${NC}"

echo -e "${BLUE}===== Downloading .gitignore ... =====${NC}"
wget "https://vincent-diquelou.github.io/others/UnityTools/UNITY.gitignore" -O .gitignore
echo -e "${GREEN}===== .gitignore downloaded =====${NC}"

echo -e "${BLUE}===== Downloading Utils scrips folder ... =====${NC}"
git svn clone "https://github.com/vincent-diquelou/vincent-diquelou.github.io/trunk/others/UnityTools/Utils"
rm -rf Utils/.git
mv Utils/ Assets/Scripts/
echo -e "${GREEN}===== Utils scrips folder downloaded =====${NC}"

echo -e "${BLUE}===== Downloading Tools folder ... =====${NC}"
git svn clone "https://github.com/vincent-diquelou/vincent-diquelou.github.io/trunk/others/UnityTools/Tools"
rm -rf Tools/.git
mv Tools/ Assets/Scripts/
echo -e "${GREEN}===== Tools folder downloaded =====${NC}"

echo -e "${BLUE}===== Downloading Plugins folder ... =====${NC}"
git svn clone "https://github.com/vincent-diquelou/vincent-diquelou.github.io/trunk/others/UnityTools/Plugins"
rm -rf Plugins/.git
mv Plugins/ Assets/
echo -e "${GREEN}===== Tools Plugins downloaded =====${NC}"

echo -e "${BLUE}===== Downloading ExternalAssets folder ... =====${NC}"
git svn clone "https://github.com/vincent-diquelou/vincent-diquelou.github.io/trunk/others/UnityTools/ExternalAssets"
rm -rf ExternalAssets/.git
mv ExternalAssets/ Assets/
echo -e "${GREEN}===== Tools ExternalAssets downloaded =====${NC}"
