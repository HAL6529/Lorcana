using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_138_JA_07 : CardInfo
{
    public CardInfo_138_JA_07()
    {
        this.cardNo = "138_JA_07";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ÉÇÅ[ÉäÉX";
        this.cardName2 = "å^îjÇËÇ»î≠ñæâ∆";
        this.power = 5;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AndyEstradaAndGregShrader;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
