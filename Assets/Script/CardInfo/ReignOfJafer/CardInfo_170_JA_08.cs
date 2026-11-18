using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_170_JA_08 : CardInfo
{
    public CardInfo_170_JA_08()
    {
        this.cardNo = "170_JA_08";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "アラジン";
        this.cardName2 = "用心深い衛兵";
        this.power = 1;
        this.toughness = 9;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarcelBerg;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
