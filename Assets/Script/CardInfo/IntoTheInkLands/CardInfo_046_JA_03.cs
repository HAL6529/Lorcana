using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_046_JA_03 : CardInfo
{
    public CardInfo_046_JA_03()
    {
        this.cardNo = "046_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ñÇñ@ÇÃÇŸÇ§Ç´";
        this.cardName2 = "Ç≈Ç¡Ç©Ç¢ë|èúâÆ";
        this.power = 1;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.EriWelli;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Broom };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Fantasia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
