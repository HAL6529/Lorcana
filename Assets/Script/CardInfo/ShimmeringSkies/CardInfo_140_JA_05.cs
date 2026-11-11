using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_140_JA_05 : CardInfo
{
    public CardInfo_140_JA_05()
    {
        this.cardNo = "140_JA_05";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "スクルージ・マクダック";
        this.cardName2 = "アンティーク愛好家";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CamKendell;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
