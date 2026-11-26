using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_145_JA_14 : CardInfo
{
    public CardInfo_145_JA_14()
    {
        this.cardNo = "145_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ゴー・ゴー・トマゴ";
        this.cardName2 = "長時間調査";
        this.power = 2;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AlbertoBesi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Super, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
