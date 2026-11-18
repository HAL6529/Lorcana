using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_073_JA_08 : CardInfo
{
    public CardInfo_073_JA_08()
    {
        this.cardNo = "073_JA_08";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "サルタン";
        this.cardName2 = "まぼろしの王様";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaxUlichney;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.King, EnumController.Class.Illusion };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Vanish };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
