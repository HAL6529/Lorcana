using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_172_JA_05 : CardInfo
{
    public CardInfo_172_JA_05()
    {
        this.cardNo = "172_JA_05";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ÉWÉÉÉtÉ@Å[";
        this.cardName2 = "ñ\ãsÇ»ÇÈç√ñ∞èpét";
        this.power = 0;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CamKendell;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Challenger7 };
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
