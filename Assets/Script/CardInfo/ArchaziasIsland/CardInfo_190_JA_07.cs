using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_190_JA_07 : CardInfo
{
    public CardInfo_190_JA_07()
    {
        this.cardNo = "190_JA_07";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ジャファー";
        this.cardName2 = "野心に燃える支配者";
        this.power = 3;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CesarVergara;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
