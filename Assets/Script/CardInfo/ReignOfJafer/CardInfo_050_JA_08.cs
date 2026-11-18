using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_050_JA_08 : CardInfo
{
    public CardInfo_050_JA_08()
    {
        this.cardNo = "050_JA_08";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "アブー";
        this.cardName2 = "虚像の巨象";
        this.power = 3;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Illusion };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Vanish };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
