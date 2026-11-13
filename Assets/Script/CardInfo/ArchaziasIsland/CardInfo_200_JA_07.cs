using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_200_JA_07 : CardInfo
{
    public CardInfo_200_JA_07()
    {
        this.cardNo = "200_JA_07";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "勇気の戦士";
        this.power = 1;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LeonardoGiammichele;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
