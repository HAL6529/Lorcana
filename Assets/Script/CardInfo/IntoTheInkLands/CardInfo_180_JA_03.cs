using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_180_JA_03 : CardInfo
{
    public CardInfo_180_JA_03()
    {
        this.cardNo = "180_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "リトス";
        this.cardName2 = "ロックタイタン";
        this.power = 4;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Titan };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Resist2 };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
