using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_092_JA_03 : CardInfo
{
    public CardInfo_092_JA_03()
    {
        this.cardNo = "092_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ワイルドキャット";
        this.cardName2 = "メカニック";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ValentinaGraziuso;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TaleSpin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
