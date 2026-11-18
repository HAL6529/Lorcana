using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_183_JA_08 : CardInfo
{
    public CardInfo_183_JA_08()
    {
        this.cardNo = "183_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "魔法のじゅうたん";
        this.cardName2 = "まぼろしの敷物";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AndreaParisi;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Illusion };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Vanish };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
