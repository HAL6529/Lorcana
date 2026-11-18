using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_009_JA_08 : CardInfo
{
    public CardInfo_009_JA_08()
    {
        this.cardNo = "009_JA_08";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ティアナ";
        this.cardName2 = "天性の才能";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MilicaCelikovic;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Singer6 };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
