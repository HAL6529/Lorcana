using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_062_JA_07 : CardInfo
{
    public CardInfo_062_JA_07()
    {
        this.cardNo = "062_JA_07";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉâÉWÉÉÅ[";
        this.cardName2 = "ÂáãCòOÇÃñ“å’";
        this.power = 3;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AndreaFemerstrand;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Illusion };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
