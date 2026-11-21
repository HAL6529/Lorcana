using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_224_JA_09 : CardInfo
{
    public CardInfo_224_JA_09()
    {
        this.cardNo = "224_JA_09";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "野獣";
        this.cardName2 = "礼節ある王子";
        this.power = 5;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.IanMacDonald;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol1;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
