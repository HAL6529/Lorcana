using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_114_JA_07 : CardInfo
{
    public CardInfo_114_JA_07()
    {
        this.cardNo = "114_JA_07";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ÉsÅ[Ég";
        this.cardName2 = "âFíàäCëØ";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KennethAnderson;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift4 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
