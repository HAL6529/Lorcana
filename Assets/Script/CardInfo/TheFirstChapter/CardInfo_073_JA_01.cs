using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_073_JA_01 : CardInfo
{
    public CardInfo_073_JA_01()
    {
        this.cardNo = "073_JA_01";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ウィーゼルトン公爵";
        this.cardName2 = "虎視眈々の公使";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "R.La Barbera / L.Giammichele";
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
