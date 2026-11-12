using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_073_JA_07 : CardInfo
{
    public CardInfo_073_JA_07()
    {
        this.cardNo = "073_JA_07";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "ドナルドダック";
        this.cardName2 = "ドタバタ魔法使い";
        this.power = 5;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
