using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_035_JA_08 : CardInfo
{
    public CardInfo_035_JA_08()
    {
        this.cardNo = "035_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "クロウハウザー";
        this.cardName2 = "受付担当";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.DennyMinonne;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard, EnumController.KeywordAvility.Singer4 };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
