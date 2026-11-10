using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_040_JA_03 : CardInfo
{
    public CardInfo_040_JA_03()
    {
        this.cardNo = "040_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "イアーゴ";
        this.cardName2 = "オウムちゃん";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GiuliaRiva;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
