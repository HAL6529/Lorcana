using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_140_JA_03 : CardInfo
{
    public CardInfo_140_JA_03()
    {
        this.cardNo = "140_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "フリントハート・グロムゴールド";
        this.cardName2 = "不正な独り者";
        this.power = 3;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FedericoMCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
