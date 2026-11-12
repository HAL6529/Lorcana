using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_050_JA_07 : CardInfo
{
    public CardInfo_050_JA_07()
    {
        this.cardNo = "050_JA_07";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "チェルナボーグ";
        this.cardName2 = "闇夜の魔人";
        this.power = 2;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GiuliaRiva;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Fantasia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
