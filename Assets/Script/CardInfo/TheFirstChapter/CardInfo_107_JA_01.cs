using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_107_JA_01 : CardInfo
{
    public CardInfo_107_JA_01()
    {
        this.cardNo = "107_JA_01";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "フック船長";
        this.cardName2 = "冷酷な海賊";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = "Cam Kendall";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.OneHundredAndOneDalmatians;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
