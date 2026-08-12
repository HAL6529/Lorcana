using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_143_JA_01 : CardInfo
{
    public CardInfo_143_JA_01()
    {
        this.cardNo = "143_JA_01";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "‘º’·ƒgƒDƒC";
        this.cardName2 = "‘¸Œh‚³‚ê‚éŽw“±ŽÒ";
        this.power = 3;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = "Pirel";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Support };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
