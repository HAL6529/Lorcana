using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_075_JA_05 : CardInfo
{
    public CardInfo_075_JA_05()
    {
        this.cardNo = "075_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉtÉçÅ[Éâ";
        this.cardName2 = "ãCÇÃÇ¢Ç¢ódê∏";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Fairy };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
